using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject coinPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CoinSpawn (){
        float randx=Random.Range(-1.85f,1.85f);
        Instantiate(coinPrefabs, new Vector3(randx, transform.position.y,transform.position.z) ,Quaternion.identity);
    }
    IEnumerator CoinSpawner(){
        while(true){
            int time = Random.Range(5,15);
            yield return new WaitForSeconds(time);
            CoinSpawn();
        }
    }
}
