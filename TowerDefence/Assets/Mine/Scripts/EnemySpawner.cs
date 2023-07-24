using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemylist;

    public float spawnRate = default;
    private float timeAfterSpawn = default;
    private bool isAllClear = true;
    private float spawnerSpeed = 0.5f;
    private Rigidbody spawner = default;



    private float respawnTimer = default;
    private float respawnRate = default;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawner = GetComponent<Rigidbody>();

    }



    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        //Debug.Log(enemylist);
        if (isAllClear == true)
        {
            if (enemylist < 30)
            {

                if (timeAfterSpawn >= spawnRate)
                {
                    timeAfterSpawn = 0;

                    GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);

                        enemylist += 1;

                }
            }
            else
            {
                isAllClear = false;
            }
        }
        if (enemylist == 0)
        {

            respawnTimer += Time.deltaTime;

            if (respawnTimer >= respawnRate)
            {
                respawnTimer = 0;
                if (!isAllClear)
                {
                    isAllClear = true;

                }
                respawnRate = 0.5f;
            }

        }
        //if (transform.position.x <= -4)
        //{
        //    gotoRight = true;
        //    gotoLeft = false;
        //}
        //else if (transform.position.x >= 4)
        //{
        //    gotoLeft = true;
        //    gotoRight = false;
        //}
        //if (gotoRight)
        //{
        //    Vector3 moveSpawner = new Vector3(spawnerSpeed, 0f, 0f);
        //    spawner.velocity = moveSpawner;
        //    //Debug.Log("���������ΰ�����");

        //}
        //else if (gotoLeft)
        //{
        //    Vector3 moveSpawner = new Vector3(-spawnerSpeed, 0f, 0f);
        //    spawner.velocity = moveSpawner;
        //    //Debug.Log("�������ΰ�����");

        //}


    }
}