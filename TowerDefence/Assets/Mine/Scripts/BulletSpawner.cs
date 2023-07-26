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
            target = other.transform; // �÷��̾ �ݶ��̴��� ������ Ÿ�� ����
            isFire = true; // ���� ���·� ����
        }

    }
    private void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Enemy"))
        {
            isFire = false; // �÷��̾ �ݶ��̴��� ������ ���� ���� ����
            target = null; // Ÿ�ٵ� null�� �ʱ�ȭ
        }


    }
}