using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoure_Manager : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;
    public int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(score());
        highScore = PlayerPrefs.GetInt("high_score" , 0);
        Debug.Log("High Score Stored :" + highScore);
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
        }
    }
}
