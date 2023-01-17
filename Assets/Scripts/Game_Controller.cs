using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public Text highscoreText;
    public Text scoreText;
    public int score;
    public int highscore;
    public Scoure_Manager score_manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscore = PlayerPrefs.GetInt("high_score");
        score = score_manager.Score;
        highscoreText.text = "High Score : " + highscore.ToString();
        scoreText.text = "Your Score : " + score.ToString();
    }
}
