using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;

    public int maxScore;

    public BallControl ball;
    
    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBall();

        if (leftScore >= maxScore)
        {
            Debug.Log("Player 2 Win");
            GameOver();
        }
    }

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();

        if (rightScore >= maxScore)
        {
            Debug.Log("Player 1 Win");
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
