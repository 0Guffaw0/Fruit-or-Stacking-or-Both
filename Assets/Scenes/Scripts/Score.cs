using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score;
    public TMP_Text textDisplay;

    private void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddToScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        textDisplay.text = $"Score: {score}";
    }
}
