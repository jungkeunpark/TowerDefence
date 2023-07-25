using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;


public class TowerUi : MonoBehaviour
{
    public GameObject BackMap;
    public GameObject cannonPrefab;
    private Vector3 previousCanonPosition;
    public BoxCollider BackMapCollider;
    private GameObject canon;
    public int Gamemoney;
    public float Price = default;
    public GameObject DESC;


    public bool draggable;
    
    


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = CastRay();

            if(hit.transform == transform)
            {
                canon = Instantiate(cannonPrefab, Vector3.zero, Quaternion.identity);

                draggable = true;

                previousCanonPosition = canon.transform.position;
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            draggable = false;

            if (!BackMapCollider.bounds.Contains(canon.transform.position))
            {
                canon.transform.position = previousCanonPosition;
            }
            GameManager.instance.gamemoney -= 10;

        }
        if(draggable)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(transform.position).z);
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
            canon.transform.position = new Vector3(worldPosition.x, 0.5f, worldPosition.z);
        }
        
    }

    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        Vector3 worldMousePosFar = Camera.main.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = Camera.main.ScreenToWorldPoint(screenMousePosNear);

        RaycastHit hit;
        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);
        return hit;
    }

    private void OnMouseDown()
    {
        DESC.SetActive(true);

    }

    private void OnMouseUp()
    {
        DESC.SetActive(false);
    }
}
