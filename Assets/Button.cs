using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Canvas menuCanvas;
    GameObject map;
    GameObject car;

    // Use this for initialization
    void Start()
    {
        menuCanvas = GameObject.Find("Menu").GetComponent<Canvas>();
        map = GameObject.Find("Minimap");
        car = GameObject.Find("Taxi");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        menuCanvas.enabled = false;
        car.GetComponent<PlayerControll>().enabled = true;
        map.GetComponent<Canvas>().enabled = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
