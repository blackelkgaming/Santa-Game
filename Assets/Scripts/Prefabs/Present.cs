using System;
using System.Collections;
using System.Collections.Generic;
using Classes;
using TMPro;
using UnityEngine;

public class Present : MonoBehaviour
{

    public GameObject scoreBoard;

    
    void Start()
    {
        if(ShootButton.matSwitch)
        {
            ShootButton.matSwitch = false;
        }
        else
        {
            ShootButton.matSwitch = true;
        }
        
        GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 9.0f, 2.0f), ForceMode.Impulse);
        StartCoroutine(presentLife());
    }

    IEnumerator presentLife()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("House"))
        {
            ScoreKeeper.IncrementScore(100);
        }
    }
}
