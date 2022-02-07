using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,1,-4);
    
 
    void Update()
    {
        //Match the camera posiion to the player
        transform.position = player.transform.position + offset;
    }
}
