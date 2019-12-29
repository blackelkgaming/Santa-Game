using System.Collections;
using System.Collections.Generic;
using Classes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        //Save score?
        PlayerPrefs.SetInt("pScore", ScoreKeeper.GetScore());
        PlayerPrefs.Save();
        
        //Reset Score
        ScoreKeeper.ResetScore();
        
        //Load Main Menu
        SceneManager.LoadScene((int)LevelEnums.Scenes.MainMenu);
    }
}
