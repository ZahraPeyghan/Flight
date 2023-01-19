using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Planes"){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
