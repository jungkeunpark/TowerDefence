using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using UnityEditor.SceneManagement;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float moveSpeedz = default;
    private float moveSpeedX = default;
    public int EnemyHp = default;
    public Rigidbody enemyRigid = default;
    public int price = default;
    
    
    void Start()
    {
        enemyRigid = GetComponent<Rigidbody>();
        moveSpeedX = 0f;
        moveSpeedz = 100f;
        
        
    }

    private void Update()
    {





        Vector3 enemyVelocity = new Vector3(moveSpeedX, 0f, moveSpeedz);

        enemyRigid.velocity = enemyVelocity;
    }


    private void OnTriggerEnter(Collider other)
    {

        

        if (other.tag.Equals("TurningPoint"))
        {
            
            enemyRigid.velocity = Vector3.zero;
            moveSpeedz = 0f;
            moveSpeedX = -100f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }

        if (other.tag.Equals("TurningPoint2"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeedz = -100f;
            moveSpeedX = 0f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
        if (other.tag.Equals("TurningPoint3"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeedz = 0f;
            moveSpeedX = 100f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
        if (other.tag.Equals("TurningPoint4"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeedz = 100f;
            moveSpeedX = 0f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
        if (other.tag.Equals("TurningPoint5"))
        {

            enemyRigid.velocity = Vector3.zero;
            moveSpeedz = 0f;
            moveSpeedX = -100f;
            enemyRigid.transform.Rotate(0, enemyRigid.transform.rotation.y + 270, 0);
        }
    }


    public void Die()
    {
        GameManager.instance.gamemoney += price;
        gameObject.SetActive(false);
    }

}