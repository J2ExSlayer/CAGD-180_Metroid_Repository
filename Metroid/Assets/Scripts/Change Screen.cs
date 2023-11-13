using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Arroyo, Jordan
/// 11/13/2023
/// This script allows users to change between the different menus/sceens of the game
/// </summary>

public class ChangeScreen : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }

}
