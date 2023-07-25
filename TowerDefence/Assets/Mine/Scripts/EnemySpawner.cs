using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyLevel1;
    public GameObject EnemyLevel2;
    public GameObject EnemyLevel3;
    public GameObject EnemyLevel4;
    public GameObject EnemyLevel5;
    public GameObject EnemyLevel6;
    public GameObject EnemyLevel7;
    public GameObject EnemyLevel8;
    //public int monster;
    public float spawnRate = default;

    private float timeAfterSpawn = default;
    private bool isAllClear = true;
    private float spawnerSpeed = 0.5f;
    private Rigidbody spawner = default;
    private int stage = default;

    private int stagemonster;
    private int stage1monster;
    private int stage2monster;
    private int stage3monster;
    private int stage4monster;
    private int stage5monster;
    private int stage6monster;
    private int stage7monster;
    private int stage8Boss;
    private float nextstage = default;
    private float respawnTimer = default;
    private float respawnRate = default;

    // Start is called before the first frame update
    void Start()
    {
        stage = GameManager.instance.stage;
        nextstage = GameManager.instance.stageTime;
        //monster = GameManager.instance.monsternum;
        timeAfterSpawn = 0f;
        spawner = GetComponent<Rigidbody>();

    }



    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (stage1monster < 30 && stage == 1)
        {

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel1, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage1monster += 1;

            }
        }
        else if (stage2monster < 30 && GameManager.instance.stage == 2)
        {
            Debug.Log("들어왔니?");
            stagemonster = 0;
            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel2, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage2monster += 1;
            }
        }
        else if (stage3monster < 30 && GameManager.instance.stage == 3)
        {
            stagemonster = 0;

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel3, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage3monster += 1;

            }
        }
        else if (stage4monster < 30 && GameManager.instance.stage == 4)
        {
            stagemonster = 0;

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel4, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage4monster += 1;

            }
        }
        else if (stage5monster < 30 && GameManager.instance.stage == 5)
        {
            stagemonster = 0;

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel5, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage5monster += 1;

            }
        }
        else if (stage6monster < 30 && GameManager.instance.stage == 6)
        {
            stagemonster = 0;

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel6, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage6monster += 1;
            }
        }
        else if (stage7monster < 30 && GameManager.instance.stage == 7)
        {
            stagemonster = 0;

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel7, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage7monster += 1;
            }
        }
        else if (stage8Boss < 1 && GameManager.instance.stage == 8)
        {
            stagemonster = 0;

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0;

                GameObject enemy = Instantiate(EnemyLevel8, transform.position, transform.rotation);

                GameManager.instance.monsternum += 1;
                stagemonster += 1;
                stage8Boss += 1;
            }
        }


    }
}