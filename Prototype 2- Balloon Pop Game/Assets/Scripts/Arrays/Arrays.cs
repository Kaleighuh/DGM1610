using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    string[] friendnames = {"Bob", "Jessica", "Jodi", "Arther", "Tod", "Kendal", "Nikki", };
    //                      {0,1,2,3,4,5,6,7}
    public int[] numbers = {23,46,77,10,42,98,63,81};


    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("former friend" + friendnames[0]);
        Debug.Log(friendnames[3]) +" says wassup as he heads to class";
        friendnames [0] = "Veronica";
        Debug.Log("New friend" + friendnames[0]);
        */
        foreach(int numbers in numbers)
        {
            print(numbers);
        }

    }


