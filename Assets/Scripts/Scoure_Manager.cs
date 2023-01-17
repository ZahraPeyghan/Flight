using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoure_Manager : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;
    public int highScore = 0;
    public  static int lastScore = 0;
    public Text HighScoreText;
    public Text LastScoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(score());
        highScore = PlayerPrefs.GetInt("high_score" , 0);
        lastScore = PlayerPrefs.GetInt("last_score" , 0);
        HighScoreText.text = "High Score :  " + highScore.ToString();
        LastScoreText.text = "Last Score :  " + lastScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
        PlayerPrefs.SetInt("last_score",lastScore);
        if (Score > highScore){
            highScore = Score;
            PlayerPrefs.SetInt("high_score",highScore);
        }
    }
    IEnumerator score(){
        while(true){
             yield return new WaitForSeconds(2);
            Score = Score + 1;
            lastScore = Score;
        }
    }
}
