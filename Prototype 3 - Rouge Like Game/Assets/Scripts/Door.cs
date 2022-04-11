using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Player_Controller playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<Player_Controller>();
    }
    void OnTriggerEnder2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerController.key == 1)
        {
            Debug.Log("You opened the door!");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("The door is locked, you need a key.");
        }
    }
}
