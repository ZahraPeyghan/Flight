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
    public static int lastScore = 0;
    public Text HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(score());
        StartCoroutine(Reload());
        highScore = PlayerPrefs.GetInt("high_score" , 0);
        Debug.Log("Last Score :" + lastScore);
        HighScoreText.text = "High Score :" + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
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
    IEnumerator Reload(){
             yield return new WaitForSeconds(30);
             SceneManager.LoadScene("Game");
    }
}
