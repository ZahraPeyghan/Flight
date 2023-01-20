using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public Transform transform;
    public float Speed=6f;
    public float RatationSpeed=6f;
    public  AudioSource CoinSound;
    public Scoure_Manager Score_Value;
    public GameObject gameoverpanel;
    public GameObject bulletprefabs;
    public float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        gameoverpanel.SetActive(false);
        Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
        Movment();
        Shooting();
        Clamp();
    }
     public void Movment(){
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
        pos.x=Mathf.Clamp(pos.x,-4.11f,4.11f);
        transform.position=pos;
    }
    void Shooting(){
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject bullet = Instantiate(bulletprefabs);
            bullet.transform.SetParent(transform.parent);
            bullet.transform.position = transform.position;
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0, bulletspeed , transform.position.z);
            Destroy(bullet, 5);
        }
    }
    private void OnTriggerEnter2D (Collider2D collition){
        if(collition.gameObject.tag == "Planes"){
            Time.timeScale=0;
            gameoverpanel.SetActive(true);
        }
        if(collition.gameObject.tag == "Coin"){
            CoinSound.Play();
            Score_Value.Score +=10;
            Destroy(collition.gameObject);
        }
        if(collition.gameObject.tag == "Heart"){
            CoinSound.Play();
            Speed = 8f;
            Destroy(collition.gameObject);
        }
    }

    public override bool Equals(object obj)
    {
        return obj is Player_Movment movment &&
               EqualityComparer<AudioSource>.Default.Equals(CoinSound, movment.CoinSound);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(CoinSound);
    }
}
