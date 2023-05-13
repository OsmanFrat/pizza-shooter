using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI liveText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
        liveText.text = "Lives: " + lives;

    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
        scoreText.text = "Score: " + score;

    }
}
