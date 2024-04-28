using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Increase score when hitting an enemy
            score += 1;
            // Update the score text
            scoreText.text = "Score: " + score;
            
        }

        if (other.CompareTag("Target"))
        {
            // Increase score when hitting an enemy
            score += 5;
            // Update the score text
            scoreText.text = "Score: " + score;

        }
    }
}
