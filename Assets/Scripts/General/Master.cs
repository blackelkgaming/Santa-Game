using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{

    private static Master master;
    
    private void Awake()
    {
        //Make sure there is only one instance of a master obj
        if (master == null)
        {
            master = this;
            DontDestroyOnLoad(this);    //The master lives while the game runs
        }
        else
        {
            DestroyImmediate(this);
        }
    }
    
    
    
    

}
