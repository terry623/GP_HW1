﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    Rigidbody m_rigid;
    GameObject cam;
    AudioSource engineSound;

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
        engineSound = GetComponent<AudioSource>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
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

    void FixedUpdate()
    {
        if (!engineSound.isPlaying) engineSound.Play();

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * 1.0f);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * 1.0f);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * 1.0f);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * 1.0f);
        else if (Input.GetKeyDown(KeyCode.R))
            transform.position = initPos;
        else engineSound.Stop();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
        }

    }

}
