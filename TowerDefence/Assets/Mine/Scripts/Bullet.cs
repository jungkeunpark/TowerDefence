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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            EnemyMove enemyMove = other.GetComponent<EnemyMove>();

            if(enemyMove != null ) 
            {
                enemyMove.EnemyHp -= Damage;
            }
            else if(enemyMove.EnemyHp -Damage < 0)
            {
                enemyMove.Die();
            }
        }
    }
}
