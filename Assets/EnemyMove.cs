using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Object Enemy;
    int enemyProbability = 20;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int ranNum = (int)(Random.value * 100);
            print("敵人亂數: " + ranNum + ", 機率為 " + enemyProbability);

            if (ranNum < enemyProbability)
            {
                print("有 1 輛警車產生了");
                GameObject enemy = GameObject.Instantiate(Enemy, Vector3.zero, Quaternion.identity) as GameObject;
                enemy.transform.position = transform.position - transform.forward * 15.0f;
            }
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 0.5f);
    }

    void OnCollisionEnter(Collision other)
    {
        Vector3 rotateDegree = new Vector3(0.0f, Mathf.Round(Random.Range(1, 3)) * 90.0f, 0.0f);
        transform.Rotate(rotateDegree);
    }
}
