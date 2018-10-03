using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour
{

    public Light lt;

    // Use this for initialization
    void Start()
    {
        lt = GetComponent<Light>();
        lt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lt.enabled = !lt.enabled;
        }
    }
}
