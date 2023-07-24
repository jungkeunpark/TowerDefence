using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TowerController : MonoBehaviour
{
    public float attackRange = 5f; // 타워의 공격 범위 설정
    public float attackInterval = 1f; // 타워의 공격 간격 설정
    private Transform target = default;
    private float lastAttackTime;
    public GameObject bulletPrefab = default;

    private void Update()
    {
        // 일정 간격마다 공격을 시도합니다.
        if (Time.time - lastAttackTime >= attackInterval)
        {
            AttackMonsterInRange();
        }
    }

    private void AttackMonsterInRange()
    {
        // 타워 주변에 있는 몬스터를 검색합니다.
        Collider[] colliders = Physics.OverlapSphere(transform.position, attackRange);
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        // 몬스터를 찾았을 경우, 가장 가까운 몬스터를 공격합니다.
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                target = FindObjectOfType<EnemyMove>().transform;
                bullet.transform.LookAt(target);
                transform.LookAt(target);
            }
        }

        lastAttackTime = Time.time; // 마지막 공격 시간을 업데이트합니다.
    }
}
