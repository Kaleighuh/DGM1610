using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = -10.0f;
    public Score_Manager scoreManager; // A variable to reference the ScoreManager
    private Ballon Ballon;

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component
        scoreManager = GameObject.Find("Score_Manager").GetComponent<Score_Manager>();
        Ballon = GetComponent<Ballon>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the ballon downward
        transform.Translate(Vector3.down * Time.deltaTime);

        //Destroy the Ballon after it passes lowerbound
        if(transform.position.y < lowerBound)
        {
            Score_Manager.DecreaseScoreText(Ballon.ScoreToGive);
            Destroy(gameObject);
        }
    }
}
