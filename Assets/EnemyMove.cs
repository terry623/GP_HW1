using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 1.0f);
    }

    void OnCollisionEnter(Collision other)
    {
        Vector3 TurnLeft = new Vector3(0.0f, -90.0f, 0.0f);
        transform.Rotate(TurnLeft);
    }
}
