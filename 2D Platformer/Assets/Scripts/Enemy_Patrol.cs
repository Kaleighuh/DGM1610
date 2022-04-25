using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Patrol : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool moveRight = true;
    public Transform groundDetection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Move the enemy at edge to the left
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        if(groundInfo.collider == false)
        {
            if(moveRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {
                // flip enemy at edge to move in the right
                transform.eulerAngles = new Vector3(0,0,0);
                moveRight = true;
            }
        }
    }
}
