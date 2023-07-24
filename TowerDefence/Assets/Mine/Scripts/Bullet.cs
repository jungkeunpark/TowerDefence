using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = default;
    private Rigidbody rigid = default;
    private float Damage = 10;
    

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;
        
        //Destroy(gameObject,3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            EnemyMove enemyMove = other.GetComponent<EnemyMove>();
        }
    }
}
