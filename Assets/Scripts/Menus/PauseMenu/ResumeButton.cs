using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ResumeButton : MonoBehaviour, IPointerClickHandler
{

    public Canvas pauseMenu;

    public void OnPointerClick(PointerEventData eventData)
    {
        pauseMenu.gameObject.SetActive(false);
    }
}
