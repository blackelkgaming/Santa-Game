using System;
using System.Collections;
using System.Collections.Generic;
using Classes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        string tag = eventData.pointerPressRaycast.gameObject.tag;
        ScoreKeeper.SetScore(PlayerPrefs.GetInt("pScore"));
        SceneManager.LoadScene((int) Enum.Parse(typeof(LevelEnums.Scenes), tag));
    }
}
