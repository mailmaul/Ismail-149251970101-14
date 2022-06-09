using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Created by ISMAIL - 149251970101-14");
        SceneManager.LoadScene("Game");
    }
}
