using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballonPrefabs;
    public float startDelay =  0.5f;
    public float spawnInterval = 1.5f;

    //public int balloonIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }
    void SpawnRandomBalloon()
    {
        //get a random position on the x axis
        Vector3 spawnPos = new Vector3 (Random.Range(-5,5),10,0);
        //select a random ballon from the ballon array
        int ballonIndex = Random.Range(0,ballonPrefabs.Length);
        //create or spawn random ballons
        Instantiate(ballonPrefabs[ballonIndex], spawnPos, ballonPrefabs[ballonIndex].transform.rotation);
    }
}
