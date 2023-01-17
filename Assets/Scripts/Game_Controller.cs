using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
    public Text highscoreText;
    public Text scoreText;
    public int score;
    public int highscore;
    public Scoure_Manager score_manager;
    public GameObject gamepousepanel;
    public GameObject gamepousebutton;
    // Start is called before the first frame update
    void Start()
    {
        gamepousepanel.SetActive(false);
        gamepousebutton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        highscore = PlayerPrefs.GetInt("high_score");
        score = score_manager.Score;
        highscoreText.text = "High Score : " + highscore.ToString();
        scoreText.text = "Your Score : " + score.ToString();
    }
    public void Restart(){
        SceneManager.LoadScene("Game");
    }
    public void Home(){
        SceneManager.LoadScene("Menu");
    }
    public void Pouse(){
        Time.timeScale=0;
        gamepousepanel.SetActive(true);
        gamepousebutton.SetActive(false);
    }
    public void Resume(){
        Time.timeScale=1;
        gamepousepanel.SetActive(false);
        gamepousebutton.SetActive(true);
    }
}
