using System.Collections;
using System.Collections.Generic;
using Classes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private TextMeshProUGUI scoreBoard;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreBoard = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreBoard)
        {
            scoreBoard.text = ScoreKeeper.GetScoreAsString();
        }
    }
}
