using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Maze");
        DisableSomeFunction();
    }

    //關閉Button以免使用者在切換場景時亂按
    private void DisableSomeFunction()
    {
        GameObject.Find("start_Button").GetComponent<UnityEngine.UI.Button>().enabled = false;
        GameObject.Find("quit_Button").GetComponent<UnityEngine.UI.Button>().enabled = false;
    }
}
