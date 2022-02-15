using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    public int ScoreToGive = 100; // Score that is given for the popped ballon
    public int ClicksToPop = 3; // How many clicks it takes to pop the ballon
    public float InflationScale = .75f; // How much the ballon increases per click

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() // Holding and clicking down on the Mouse
    {
        //Reduce number of needed clicks by one
        ClicksToPop -= 1;
        //Increases the size of the ballon
        transform.localScale += Vector3.one * InflationScale;

        if (ClicksToPop == 0)
        {
            Destroy(gameObject);
        }

    }
}
