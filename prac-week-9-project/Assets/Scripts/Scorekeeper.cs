using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeper : MonoBehaviour
{
    public int pointGain = 1;           // Points gained per coin pickup
    private int currentScore = 0;       // Private state of current score
    
    // Public method returns currentScore
    public int GetCurrentScore()
    {
        get
        {
            return currentScore;        // Return currentScore state in read-only
        }
    }

    // Public method increases currentScore
    public void IncreaseScore()
    {
        currentScore += pointGain;      // Increase currentScore state by pointGain parameter
    }
}