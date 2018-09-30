using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    float x = 0.0f;
    float y = 0.0f;

    // Use this for initialization
    void Start()
    {
        Vector3 angle;
        angle = transform.eulerAngles;
        x = angle.y;
        y = angle.x;
    }

    // Update is called once per frame
    void Update()
    {
        x += Input.GetAxis("Mouse X") * 4;
        y -= Input.GetAxis("Mouse Y") * 4;

        Quaternion rotationCamera = Quaternion.Euler(y, x, 0.0f);
        transform.rotation = rotationCamera;
    }

}
