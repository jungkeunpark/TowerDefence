using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRate = 0.5f;

    private Transform target;
    private float timeAfterSpawn;
    private bool isFire = false;

    private void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = 0.5f;
        target = null;
    }

    private void Update()
    {
        if (target != null & isFire)
        {

            timeAfterSpawn += Time.deltaTime;

            if (timeAfterSpawn >= spawnRate)
            {

                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.transform.LookAt(target);
                timeAfterSpawn = 0;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            target = other.transform; // 플레이어가 콜라이더에 들어오면 타겟 설정
            isFire = true; // 공격 상태로 변경
        }

    }
    private void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Enemy"))
        {
            isFire = false; // 플레이어가 콜라이더를 나가면 공격 상태 해제
            target = null; // 타겟도 null로 초기화
        }


    }
}