using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    public float Speed=10f;
      void Update()
    {
       transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Planes"){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
