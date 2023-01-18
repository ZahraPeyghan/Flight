using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest_Movment : MonoBehaviour
{
     public Renderer meshRenderer;
     public float Speed=0.1f;
     public GameObject Forest;
    // Start is called before the first frame update
    void Start()
    {
        Forest.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset+= new Vector2 (0, Speed * Time.deltaTime);
    }
}
