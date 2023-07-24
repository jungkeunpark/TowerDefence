using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float stage = default;
    private float Money = default;
    public GameObject TowerBase = default;

    public GameObject GameOverUi = default;
    public TMP_Text timetext = default;
    public TMP_Text scoretext = default;

    private float stageTime = default;
    private bool isGameOver = default;

    void Start()
    {
        stageTime = 120f;
        isGameOver = false;
    }


    void Update()
    {
        if(isGameOver == false)
        {
            stageTime -= Time.deltaTime;
            timetext.SetText(string.Format("NextStage:{0:F2}", stageTime));

        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            GFunc.LoadScene("SampleScene");
        }

    }
}
