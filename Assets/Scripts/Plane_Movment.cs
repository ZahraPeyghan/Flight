using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Movment : MonoBehaviour
{
    public Transform transform;
    public float Speed=4f;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent <Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,Speed * Time.deltaTime,0);
    }
}
