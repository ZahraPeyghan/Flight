using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Spawner : MonoBehaviour
{
    public GameObject[] plane;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPlanes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void Plane()
    {
            int rand = Random.Range(0,plane.Length);
            float randXPos= Random.Range(-1.85f,1.85f);
            Instantiate(plane[rand], new Vector3(randXPos, transform.position.y,transform.position.z) ,Quaternion.Euler(0,0,0));
        
    }

    IEnumerator SpawnPlanes() {
       while(true){
             yield return new WaitForSeconds(4);
               Plane();
       }
       
    }
}
