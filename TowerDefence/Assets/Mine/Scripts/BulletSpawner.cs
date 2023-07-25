using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRate = 0.5f;

    private Transform target;
    private float timeAfterSpawn;
    private bool isFire = false;

    private void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = 0.5f;
        target = FindObjectOfType<EnemyMove>().transform;
    }

    private void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            timeAfterSpawn = 0;
        }

    }
    private void OnTriggerEnter(Collider other)
    {


        Debug.LogFormat("적이 내콜라이더에 들어왔냐?");
        isFire = true;



    }
    private void OnTriggerExit(Collider other)
    {


        isFire = false;
        Debug.LogFormat("적이 내콜라이더에서 나갔냐?");


    }
}