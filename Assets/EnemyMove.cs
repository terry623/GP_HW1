using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody m_rigid;

    // Use this for initialization
    void Start()
    {
        m_rigid = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        m_rigid.AddForce(Vector3.forward * 1000.0f);
    }
}
