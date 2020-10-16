using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    private int currentScore;
    private Scorekeeper scorekeeperScript;
    private Text scoreText;
    private UIScript uiScript;

    void Start()
    {
        scorekeeperScript = GameObject.Find("Scorekeeper").GetComponent<Scorekeeper>();     // Get scorekeeper script
        scoreText = GameObject.Find("Score Canvas/Score Text").GetComponent<Text>();        // Get score text
        uiScript = GameObject.Find("UIManager").GetComponent<UIScript>();                   // Get UI script
    }

    void Update()
    {
        currentScore = scorekeeperScript.GetCurrentScore;
        scoreText.text = "Score: "+currentScore;        
    }
}
