using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class WorldsMenuButton : MonoBehaviour, IPointerClickHandler
{

    private SceneLoader loader;

    private void Awake()
    {
        loader = (SceneLoader)FindObjectOfType(typeof(SceneLoader));
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        
        loader.LoadLevel((int) LevelEnums.Scenes.WorldsMenu);
        
    }
}
