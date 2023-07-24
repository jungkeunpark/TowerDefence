using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab = default;
    private float spawnRate = default;
    private float timeAfterSpawn = default;

    private Transform target = default;

    void Start()
    {

        timeAfterSpawn = 0f;
        spawnRate = 0.5f;
        

    }

    private void OnTriggerEnter(Collider other)
    {
        target = FindObjectOfType<EnemyMove>().transform;

        


            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            bullet.transform.LookAt(target);
            transform.LookAt(target);
        
    }
}
