using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TowerController : MonoBehaviour
{
    public float attackRange = 5f; // Ÿ���� ���� ���� ����
    public float attackInterval = 1f; // Ÿ���� ���� ���� ����
    private Transform target = default;
    private float lastAttackTime;
    public GameObject bulletPrefab = default;

    private void Update()
    {
        // ���� ���ݸ��� ������ �õ��մϴ�.
        if (Time.time - lastAttackTime >= attackInterval)
        {
            AttackMonsterInRange();
        }
    }

    private void AttackMonsterInRange()
    {
        // Ÿ�� �ֺ��� �ִ� ���͸� �˻��մϴ�.
        Collider[] colliders = Physics.OverlapSphere(transform.position, attackRange);
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        // ���͸� ã���� ���, ���� ����� ���͸� �����մϴ�.
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                target = FindObjectOfType<EnemyMove>().transform;
                bullet.transform.LookAt(target);
                transform.LookAt(target);
            }
        }

        lastAttackTime = Time.time; // ������ ���� �ð��� ������Ʈ�մϴ�.
    }
}
