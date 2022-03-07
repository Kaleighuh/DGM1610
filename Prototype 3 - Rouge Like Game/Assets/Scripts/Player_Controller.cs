using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed = 5f; // speed at which the player moves
    private Rigidbody2D rb; // Store the referenced 2D rigidbody

    Vector2 movement; //  Store the players x and y positions



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Left and right movement
        movement.y = Input.GetAxis("Vertical"); // Up and down movement
    }
    // Set number of calls per fram
    void FixedUpdate()
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
