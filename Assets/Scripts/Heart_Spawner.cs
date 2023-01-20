using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Spawner : MonoBehaviour
{
    public GameObject heartPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HeartSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void HeartSpawn (){
        float randx=Random.Range(-4.11f,4.11f);
        Instantiate(heartPrefabs, new Vector3(randx, transform.position.y,transform.position.z) ,Quaternion.identity);
    }
    IEnumerator HeartSpawner(){
        while(true){
            int time = Random.Range(8,20);
            yield return new WaitForSeconds(time);
            HeartSpawn();
        }
    }
}
