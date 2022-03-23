using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplecalc : MonoBehaviour
{

    //Access modifier datatype name;
    public int numberA = 10;
    public int numberB = 33;
    public int numberC = 7;
    public float numberD = 33.0f;
    public float numberE = 7.0f;

    // + - * /

    // Start is called before the first frame update
    void Start()
    {
        Add();
        Sub();
        Mult();
        Div();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Add()
    { 
        int total;

        total = numberA + numberB;

        Debug.Log(numberA + "+" + numberB + "=" + total);

    }

    void Sub()
    {
        int total;

        total = numberB - numberC;

        Debug.Log(numberB + "-" + numberC + "=" + total);

    }
    void Mult()
    {
        int total;

        total = numberB * numberB;

        Debug.Log(numberB + "*" + numberB + "=" + total);

    }
    void Div()
    {
        int total;
        int rem;
        float tot;

        total = numberC / numberB;
        rem = numberB % numberC ;
        tot = numberD / numberE;

        Debug.Log(numberC +" / "+ numberB +" = "+ total);
        Debug.Log("remainder = "+ rem );
        Debug.Log(numberD +" / "+ numberE +" = "+ tot);

    }
}
