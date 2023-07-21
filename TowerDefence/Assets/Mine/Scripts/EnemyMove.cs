using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = default;
    public float moveSpeedX = default;
    public Rigidbody enemyRigid = default;
    public BoxCollider boxCollider = default;
    void Start()
    {
        enemyRigid = GetComponent<Rigidbody>();
        moveSpeedX = 0f;
    }

    private void Update()
    {
       




        Vector3 enemyVelocity = new Vector3(moveSpeedX, 0f, moveSpeed);

        enemyRigid.velocity = enemyVelocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (enemyRigid != null)
        {
            enemyRigid.velocity = Vector3.zero;

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        

        if (other.tag.Equals("TurningPoint"))
        {
            
            enemyRigid.velocity = Vector3.zero;
            moveSpeed = 0f;
            moveSpeedX = -100f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }

        if (other.tag.Equals("TurningPoint2"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeed = -100f;
            moveSpeedX = 0f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
        if (other.tag.Equals("TurningPoint3"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeed = 0f;
            moveSpeedX = 100f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
        if (other.tag.Equals("TurningPoint4"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeed = 100f;
            moveSpeedX = 0f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
        if (other.tag.Equals("TurningPoint5"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeed = 0f;
            moveSpeedX = -100f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
    }


    public void Die()
    { }

}