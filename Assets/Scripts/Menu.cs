using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public  AudioSource GameSound;
    // Start is called before the first frame update
    void Start()
    {
        GameSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneGame(){
    SceneManager.LoadScene("Game");
    }
}
