using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Canvas menuCanvas;
    GameObject car;

    // Use this for initialization
    void Start()
    {
        menuCanvas = GameObject.Find("Menu").GetComponent<Canvas>();
        car = GameObject.Find("Taxi");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        menuCanvas.enabled = false;
        Cursor.visible = false;
        car.GetComponent<PlayerControll>().enabled = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
