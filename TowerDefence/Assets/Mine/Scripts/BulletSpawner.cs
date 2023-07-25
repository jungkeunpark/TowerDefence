using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRate = 0.5f;

    private Transform target;
    private float timeAfterSpawn;

    private void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = 0.5f;
        target = FindObjectOfType<EnemyMove>().transform;
    }

    private void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
            spawnRate = 0.5f;
        }
    }
}