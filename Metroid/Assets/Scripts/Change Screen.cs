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

    // create a tutorial scene with the players controls on it!!!

    // create a Winning the game scene UI!!! game manager object that held enemies, an array that holds all of them and checks to see if there are no more
    // empty object under enemies/children transform child count that returns, check if child count is less than or equal to zero
    // parent gameobject that holds all the enemies as children, the parent script checks to see how many children it has left, transform.childcount = line that checks how many children are left, if transform.childcount <= 0 change scene.

}
