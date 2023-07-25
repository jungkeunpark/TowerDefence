//using UnityEngine;
//using System;
//using TMPro;
//using UnityEditor;
//using UnityEngine.AI;
//using static BulletSpawner;

//public class Shoot : MonoBehaviour
//{
//    public GameObject shootingRange;
//    public GameObject muzzleFire = default;
//    public GameObject bulletPrefab = default;

//    public bool isFirstSet;
//    public int type;

//    private Transform target = default;
//    private float spawnRate = default;
//    private float timeAfterSpawn = default;

//    private bool isShooting = default;
//    public float bulletHeight;

//    private bool targetOn = false;
//    private Transform targetTrans;
//    private bool targetInRange = false;
//    private Vector3 targetPosition;
//    private bool isClick = false;

//    public TurretState turretState;
//    private AudioSource shootSound;

//    void Start()
//    {
//        isFirstSet = true;
//        timeAfterSpawn = 0.5f;
//        turretState = TurretState.Installation;
        

//    }

//    private void OnTriggerStay(Collider other)
//    {
//        if (other.tag.Equals("Enemy"))
//        {
//            targetInRange = true;
//            if (targetTrans == null)
//            {
//                targetTrans = other.transform;
//                targetOn = true;
//            }
//        }
//    }

//    private void OnTriggetEnter(Collider other)
//    {
//        if (other.CompareTag("Enemy") && targetOn == false)
//        {
//            targetOn = true;
//            targetTrans = other.transform;
//        }
//    }
//    private void OnTriggerExit(Collider other)
//    {
//        if (other.transform == target)
//        {
//            targetOn = false;
//            targetTrans = null;
//        }
//        if (other.tag.Equals("Enemy"))
//        {
//            targetInRange = false;
//            targetOn = false;
//            targetTrans = null;
//        }
//    }
//    void Update()
//    {

//        if (targetOn == true && targetTrans != null)
//        {
//            if (IsTargetAlive(targetTrans) && IsTargetInRange(targetTrans))
//            {

//                targetPosition = new Vector3(targetTrans.transform.position.x, transform.position.y, targetTrans.transform.position.z);
//                transform.LookAt(targetPosition);
//                timeAfterSpawn += Time.deltaTime;
//                if (timeAfterSpawn >= spawnRate)
//                {
//                    Vector3 bulletSpawnPosition = transform.position + transform.forward * bulletHeight;


//                    timeAfterSpawn = 0;
//                    Vector3 muzzleRotation = new Vector3(0f, 90f, 0f);
//                    Quaternion mzlRotation = Quaternion.Euler(muzzleRotation);
//                    GameObject muzzle = Instantiate(muzzleFire, bulletSpawnPosition, transform.rotation);
//                    GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition, transform.rotation);
//                    bullet.transform.LookAt(targetPosition);
//                    isShooting = true;

//                    Destroy(muzzle, 0.5f);

//                }

//            }
//            else
//            {
//                targetOn = false;
//                targetTrans = null;
//            }


//        }
    

//    }
//    private bool IsTargetAlive(Transform target_)
//    {
//        if (target_.GetComponent<EnemyMove>().EnemyHp == 0)
//        {
//            return false;
//        }
//        else
//        {
//            return true;
//        }

//    }

//    private bool IsTargetInRange(Transform target_)
//    {
//        if (targetInRange == true)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }

//}




