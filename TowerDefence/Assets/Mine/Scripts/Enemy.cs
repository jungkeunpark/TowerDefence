using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody EnemyRigid = default;
    public float speed = default;
    void Start()
    {
        EnemyRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
}
