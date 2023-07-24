using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Towerbase : MonoBehaviour
{
    public GameObject makingportal = default;

    public GameObject TowerMenuText1 = default;
    public GameObject TowerMenuText2 = default;
    public GameObject TowerMenuUi = default;

    private bool Die = default;
    private float Money = default;

    private bool isTower = default;

    void Start()
    {
        Money = 0f;
        isTower = false;
        makingportal = GetComponent<GameObject>();
        
        
    }



    void Update()
    {

        
        if(Input.GetMouseButtonDown(0)) 
        {
            TowerMenuUi.SetActive(true);
            
        }
    }
}
