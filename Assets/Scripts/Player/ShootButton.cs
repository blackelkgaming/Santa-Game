using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    private bool _shootPressed;
    public static bool matSwitch = true;

    public void OnPointerUp(PointerEventData eventData)
    {
        _shootPressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _shootPressed = true;
    }

    public bool getPressed()
    {
        return _shootPressed;
    }

}
