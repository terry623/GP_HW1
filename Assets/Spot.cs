using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour
{
    public Light lt;
    public Light mainLt;

    // Use this for initialization
    void Start()
    {
        lt = GetComponent<Light>();
        mainLt = GetComponent<Light>();
        lt.enabled = !mainLt.enabled;
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
