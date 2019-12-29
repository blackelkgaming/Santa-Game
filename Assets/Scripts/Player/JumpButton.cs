using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    private bool _jumpPressed;

    public void OnPointerUp(PointerEventData eventData)
    {
        _jumpPressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _jumpPressed = true;
    }

    public bool getPressed()
    {
        return _jumpPressed;
    }
}
