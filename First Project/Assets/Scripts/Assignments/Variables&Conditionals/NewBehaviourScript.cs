using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //global variables
    public int Money = 12; //Whole numbere value 2,14,57, -92 
    public float Change = 0.75f; //floating point number or decimal 3.15, 105.34, -299.99
    public bool isDay = true; //booleans are true or false
    private string firstname = "Bob"; //alpha numeric text contained in quotations


    // Start is called before the first frame update
    void Start()
    {
        Money = 125; 
        Debug.Log("money in account = " +Money); 
        //local variable
        float waterBottle = 0.35f;
        waterBottle = 1.00f;
       }

    // Update is called once per frame
    void Update()
    {
        
    }
}
