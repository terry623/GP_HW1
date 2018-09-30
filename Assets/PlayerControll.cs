using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    Rigidbody m_rigid;

    float x = 0.0f;
    float y = 0.0f;

    [Header("角色的起始位置")]
    public Vector3 initPos;

    [Header("角色目前的位置")]
    public Vector3 curPos;

    // Use this for initialization
    void Start()
    {
        initPos = this.gameObject.transform.position;
        m_rigid = this.gameObject.GetComponent<Rigidbody>();

        Vector3 angle;
        angle = transform.eulerAngles;
        x = angle.y;
        y = angle.x;
    }

    // Update is called once per frame
    void Update()
    {
        curPos = this.gameObject.transform.position;

        x += Input.GetAxis("Mouse X") * 4;

        Quaternion rotation = Quaternion.Euler(0.0f, x, 0.0f);
        transform.rotation = rotation;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * 0.75f);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * 0.75f);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * 0.75f);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * 0.75f);


        if (Input.GetKeyDown(KeyCode.Space))
            m_rigid.AddForce(Vector3.up * 2000.0f);

        if (Input.GetKeyDown(KeyCode.R))
            transform.position = initPos;
    }

    void OnCollisionEnter(Collision other)
    {
        print(other);
    }

}
