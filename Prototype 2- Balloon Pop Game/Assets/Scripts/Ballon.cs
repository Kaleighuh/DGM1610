using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    public int ScoreToGive = 100; // Score that is given for the popped ballon
    public int ClicksToPop = 3; // How many clicks it takes to pop the ballon
    public float InflationScale = .75f; // How much the ballon increases per click
    public Score_Manager scoreManager; // a variable to reference the Score_Manager. How these two scripts are connected

    // Start is called before the first frame update
    void Start()
    {
        //reference ScoreManager Component
        scoreManager = GameObject.Find("Score_Manager").GetComponent<Score_Manager>();
    }

    void OnMouseDown() // Holding and clicking down on the Mouse
    {
        //Reduce number of needed clicks by one
        ClicksToPop -= 1;
        //Increases the size of the ballon
        transform.localScale += Vector3.one * InflationScale;

        if (ClicksToPop == 0)
        {
            scoreManager.IncreaseScoreText(ScoreToGive);
            Destroy(gameObject);
        }

    }
}
