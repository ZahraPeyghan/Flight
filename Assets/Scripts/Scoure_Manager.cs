using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoure_Manager : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(score());
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
    }
    IEnumerator score(){
        while(true){
             yield return new WaitForSeconds(2);
            Score = Score + 1;
            Debug.Log("Score :" + Score);
        }
    }
}
