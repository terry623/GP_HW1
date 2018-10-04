using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHouse : MonoBehaviour
{
    public GameObject[] buildings;
    int houseProbability = 50;

    // Use this for initialization
    void Start()
    {
        buildings = GameObject.FindGameObjectsWithTag("house-wall");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int buildingNums = buildings.Length;
            int ranNum = (int)(Random.value * 100);
            print("房子亂數: " + ranNum + ", 機率為 " + houseProbability);

            if (ranNum < houseProbability)
            {
                int index = Random.Range(0, buildingNums);
                print("第 " + index + " 房子被破壞了");
                Destroy(buildings[index]);
            }
        }
    }
}

