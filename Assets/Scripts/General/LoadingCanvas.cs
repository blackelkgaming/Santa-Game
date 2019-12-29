using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingCanvas : MonoBehaviour
{
  
    private static LoadingCanvas loadingCanvas;
    
    private void Awake()
    {
        if (loadingCanvas == null)
        {
            loadingCanvas = this;
            DontDestroyOnLoad(this);    //The master lives while the game runs
        }
        else
        {
            DestroyImmediate(this);
        }

    }
}
