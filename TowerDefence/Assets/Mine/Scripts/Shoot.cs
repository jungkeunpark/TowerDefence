using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab = default;


    private Transform target = default;
    private float spawnRate = default;
    private float timeAfterSpawn = default;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;

        target = FindObjectOfType<EnemyMove>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            bullet.transform.LookAt(target);
            transform.LookAt(target);

        }
    }
}
