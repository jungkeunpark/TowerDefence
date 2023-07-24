using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour, IPointerClickHandler
{
    public GameObject towerPrefab; // 소환할 타워의 프리팹을 할당

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left) // 왼쪽 마우스 버튼 클릭만 처리
        {
            // 여기서 UI를 클릭했을 때의 동작을 구현
            // 예를 들어, 타워 소환 표시를 띄우거나 소환할 타워를 선택하는 로직을 구현

            // UI 클릭 위치를 월드 좌표로 변환
            Ray ray = Camera.main.ScreenPointToRay(eventData.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 spawnPosition = hit.point;

                // 여기서 spawnPosition 위치에 타워를 소환하기 위한 로직을 구현
                GameObject newTower = Instantiate(towerPrefab, spawnPosition, Quaternion.identity);

                // 여기서 타워에 대한 추가 설정 및 초기화를 할 수 있습니다.
            }
        }
    }


}


