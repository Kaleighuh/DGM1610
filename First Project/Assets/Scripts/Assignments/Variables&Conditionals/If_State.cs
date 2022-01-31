using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
public class NewBaseType
{
    //Global Variables

    public string characterone = "wizard";
    public string charactertwo = "soldier";
    public int hp = 100;
    public bool isdanger = true;
    public bool isdanger = false;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (isdanger == true) ;
        {
            print("RUN AWAY!");
        }
        if (isdanger == false) ;
        {
            print("Just Hang Out");
        }
        if(hp == 100);
        {
            print("Healthy");
        }
        if(hp <= 50);
        {
            print("Injured");
        }
        if(hp == 0);
        {
            print("DEAD!");
        }
        if(characterone (hp <= 50) && isdanger = true);
        {
            print("Weak Spell");
        }
        if(charactertwo (hp <= 50) && isdanger = true);
        {
            print("Weak Attack");
        }
        if(characterone !(hp <= 75 && isdanger != false));
        {
            print("Meteror");
        }
        if(charactertwo !(hp >=75 && isdanger !=false));
        {
            print("Strong Attack!");
        }
        if(characterone (hp <= 25) || isdanger = true);
        {
            print("Use Healing Potion");
        }
    }
}

