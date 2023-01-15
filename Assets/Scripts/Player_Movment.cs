using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public Transform transform;
    public float Speed=1.5f;
    public float RatationSpeed=5f;
    public  AudioSource CoinSound;
    public Scoure_Manager Score_Value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movment();
        Clamp();
    }
    void Movment(){
         if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3 (Speed * Time.deltaTime,0,0);
            transform.rotation= Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,-30f),RatationSpeed * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3 (Speed * Time.deltaTime,0,0);
            transform.rotation= Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,30f),RatationSpeed * Time.deltaTime);
        }
        if(transform.rotation.z !=0){
            transform.rotation= Quaternion.Lerp (transform.rotation,Quaternion.Euler(0,0,0),RatationSpeed * Time.deltaTime);
        }
    }
    void Clamp(){
        Vector3 pos=transform.position;
        pos.x=Mathf.Clamp(pos.x,-1.85f,1.85f);
        transform.position=pos;
    }
    private void OnTriggerEnter2D (Collider2D collition){
        if(collition.gameObject.tag == "Planes"){
            Time.timeScale=0;
        }
        if(collition.gameObject.tag == "Coin"){
            CoinSound.Play();
            Score_Value.Score +=10;
            Destroy(collition.gameObject);
        }
    }
}
