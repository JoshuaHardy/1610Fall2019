using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFruit : MonoBehaviour
{
    public bool appleisRipe, orangeIsRipe, peachIsRipe;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (appleisRipe)
        {
            print("Go Pick The Apple.");
        }
        else if (orangeIsRipe)
        {
            print("Go Pick The Orange.");
        }
        else if (peachIsRipe)
        {
            print("Go Pick The Peach.");
        }
        else
        {
            print("Nothing is Ripe.");
        }
       
    }
}
