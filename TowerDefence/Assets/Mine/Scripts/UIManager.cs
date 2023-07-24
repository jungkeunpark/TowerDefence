using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour, IPointerClickHandler
{
    public GameObject towerPrefab; // ��ȯ�� Ÿ���� �������� �Ҵ�

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left) // ���� ���콺 ��ư Ŭ���� ó��
        {
            // ���⼭ UI�� Ŭ������ ���� ������ ����
            // ���� ���, Ÿ�� ��ȯ ǥ�ø� ���ų� ��ȯ�� Ÿ���� �����ϴ� ������ ����

            // UI Ŭ�� ��ġ�� ���� ��ǥ�� ��ȯ
            Ray ray = Camera.main.ScreenPointToRay(eventData.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 spawnPosition = hit.point;

                // ���⼭ spawnPosition ��ġ�� Ÿ���� ��ȯ�ϱ� ���� ������ ����
                GameObject newTower = Instantiate(towerPrefab, spawnPosition, Quaternion.identity);

                // ���⼭ Ÿ���� ���� �߰� ���� �� �ʱ�ȭ�� �� �� �ֽ��ϴ�.
            }
        }
    }


}


