using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI scoreText;
   // Updates score when called
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText(score);
    }
    // decreases score when called
    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText(score);
    }
    // Changes the text on screen
    public void UpdateScoreText(int amount)
    {
        scoreText.text = "Score: " + score;
    }


}
