using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{   
    public Text skorKiri;
    public Text skorKanan;

    public ScoreManager manager;

    private void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
