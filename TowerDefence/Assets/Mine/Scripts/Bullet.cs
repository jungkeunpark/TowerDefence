using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = default;
    private Rigidbody rigid = default;
    public int Damage = default;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;
        Debug.LogFormat("{0}", Damage);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            EnemyMove enemyMove = other.GetComponent<EnemyMove>();

            if (enemyMove != null)
            {
                enemyMove.EnemyHp -= Damage;
                Destroy(gameObject);
                
            }
            if (enemyMove.EnemyHp - Damage < 0)
            {
                enemyMove.Die();
                GameManager.instance.monsternum -= 1;
            }
            Destroy(gameObject,2f);
        }
    }
}
