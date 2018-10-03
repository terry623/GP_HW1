using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    bool isNight = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            isNight = !isNight;
    }

    void FixedUpdate()
    {
        if (isNight)
            transform.Translate(Vector3.forward * 1.0f);
        else
            transform.Translate(Vector3.forward * 2.0f);
    }

    void OnCollisionEnter(Collision other)
    {
        Vector3 rotateDegree = new Vector3(0.0f, Mathf.Round(Random.Range(1, 3)) * 90.0f, 0.0f);
        transform.Rotate(rotateDegree);
    }
}
