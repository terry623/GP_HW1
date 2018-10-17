using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControll : MonoBehaviour
{
    public Text alert_message;
    GameObject cam;
    AudioSource engineSound;
    Canvas alertCanvas;

    float x = 0.0f;
    float y = 0.0f;
    float v = 0.8f;
    bool isEnd = false;

    [Header("角色的起始位置")]
    public Vector3 initPos;

    [Header("角色目前的位置")]
    public Vector3 curPos;

    // Use this for initialization
    void Start()
    {
        initPos = this.gameObject.transform.position;
        engineSound = GetComponent<AudioSource>();
        alertCanvas = GameObject.Find("Finish").GetComponent<Canvas>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isEnd)
        {
            curPos = this.gameObject.transform.position;
            x = Input.GetAxis("Mouse X") * 10;
            Vector3 rotate = new Vector3(0.0f, x, 0.0f);
            transform.Rotate(rotate * 1.0f);

            cam = GameObject.Find("Main Camera");
            y = Input.GetAxis("Mouse Y") * 2;
            float angle = cam.transform.eulerAngles.x + (-y);
            if (!(angle > 20 && angle < 340))
                cam.transform.RotateAround(transform.position, cam.transform.right, -y);
        }
    }

    void FixedUpdate()
    {
        if (!isEnd)
        {
            if (!engineSound.isPlaying) engineSound.Play();

            if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward * v);
            else if (Input.GetKey(KeyCode.A))
                transform.Translate(Vector3.left * v);
            else if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * v);
            else if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector3.right * v);
            else if (Input.GetKeyDown(KeyCode.R))
                transform.position = initPos;
            else engineSound.Stop();
        }
    }

    void Finish(string message)
    {
        isEnd = true;
        engineSound.Stop();
        Cursor.visible = true;
        alertCanvas.enabled = true;
        alert_message.text = message;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy") Finish("被警察抓到了");
        else if (other.gameObject.tag == "exit") Finish("成功逃出!");
    }

}
