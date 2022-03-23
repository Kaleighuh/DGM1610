using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    // Start is called before the first frame update
    public TestData data;
    void Start()
    {
        if (data.isdanger == true) ;
        {
            print("RUN AWAY!");
        }
        if (data.isdanger == false) ;
        {
            print("Just Hang Out");
        }
        if(data.hp == 100);
        {
            print("Healthy");
        }
        if(data.hp <= 50);
        {
            print("Injured");
        }
        if(data.hp == 0);
        {
            print("DEAD!");
        }
        if(data.characterone != null)
        {
            PrintStatement(data.characterone);
        }
        if((data.hp <= 50) && data.isdanger == true);
        {
            print("Weak Spell");
        }
        if((data.hp <= 50) && data.isdanger == true);
        {
            print("Weak Attack");
        }
        if(!(data.hp <= 75 && data.isdanger != false));
        {
            print("Meteror");
        }
        if(!(data.hp >=75 && data.isdanger !=false));
        {
            print("Strong Attack!");
        }
        if((data.hp <= 25) || data.isdanger == true);
        {
            print("Use Healing Potion");
        }
    }

    private void PrintStatement(string message)
    {
        print(message); 
    }
}
