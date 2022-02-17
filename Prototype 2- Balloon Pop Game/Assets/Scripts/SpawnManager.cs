using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballonPrefabs;
    public int ballonIndex; //help create random spawning
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3 (Random.Range(-5,5),10,0);
        int ballonIndex = Random.Range(0,ballonPrefabs.length);
        Instantiate(ballonPrefabs[ballonIndex], spawnPos, ballonPrefabs[ballonIndex].translate.rotation);
    }
}
