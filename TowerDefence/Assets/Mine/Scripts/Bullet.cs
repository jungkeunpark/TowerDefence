using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = default;
    private Rigidbody rigid = default;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;

        //Destroy(gameObject,3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("EnemyMove"))
        {
            EnemyMove enemyMove = other.GetComponent<EnemyMove>();

            if (enemyMove != null)
            {
                enemyMove.Die();
            }
        }
    }
}
