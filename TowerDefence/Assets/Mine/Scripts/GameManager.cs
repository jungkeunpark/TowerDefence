using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance = default;




    public GameObject TowerBase = default;
    public GameObject GameOverUi = default;
    public GameObject GameUI = default;
    public GameObject Countdown = default;
    public TMP_Text timetext = default;
    public TMP_Text scoretext = default;
    public TMP_Text Money = default;
    public TMP_Text Stage = default;
    public TMP_Text Monster = default;
    public TMP_Text Beststage = default;
    public TMP_Text Bestscore = default;


    public float stageTime = default;
    private bool isGameOver = default;
    public float gamescore = 0;
    public int gamemoney = 50;
    public int stage = 1;
    public int monsternum = default;
    private const string BestScoreKey = "BestScore";
    private const string BestLevelKey = "BestLevel";
    private int bestScore;
    private int bestLevel;

    void Start()
    {
        instance = this;
        stageTime = 30f;
        isGameOver = false;
       
    }

  

    void Update()
    {
        if(isGameOver == false)
        {
            Countdown.SetActive(false);

            stageTime -= Time.deltaTime;

            if(stageTime < 10)
            {
                Countdown.SetActive(true);
                timetext.SetText(string.Format("NextStage:{0:F2}", stageTime));
                if(stageTime <=0)
                {
                    stageTime = 30f;
                    stage += 1;
                }
            }
            scoretext.SetText(string.Format("Score: {0}", gamescore));
            Money.SetText(string.Format("Money: {0}", gamemoney));
            Stage.SetText(string.Format("Stage : {0}", stage));
            if (monsternum >= 120)
            {
                isGameOver = true;
                Die();
            }
            else if(monsternum < 100)
            {
                Monster.SetText(string.Format("Monster: {0} / 120", monsternum));
            }
            else if (monsternum>100)
            {
                ChangeTextColor(Color.red);
                Monster.SetText(string.Format("Monster: {0} / 120", monsternum));
            }

        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            GFunc.LoadScene("SampleScene");
        }

    }
    void Die()
    {
        GameUI.SetActive(false);
        TowerBase.SetActive(false);
        Bestscore.SetText(string.Format("BestScore: {0}",BestScoreKey));
        Beststage.SetText(string.Format("BestStage: {0}",BestLevelKey));
        GameOverUi.SetActive(true);


    }

    public void SaveBestScoreAndLevel()
    {
        PlayerPrefs.SetInt(BestScoreKey, bestScore);
        PlayerPrefs.SetInt(BestLevelKey, bestLevel);
    }

    public void LoadBestScoreAndLevel()
    {
        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
        bestLevel = PlayerPrefs.GetInt(BestLevelKey, 0);
    }

    public void UpdateBestScoreAndLevel(int currentScore, int currentLevel)
    {
        if (currentScore > bestScore)
            bestScore = currentScore;

        if (currentLevel > bestLevel)
            bestLevel = currentLevel;
    }

    public void ChangeTextColor(Color color)
    {
        Monster.color = color;
    }
}
