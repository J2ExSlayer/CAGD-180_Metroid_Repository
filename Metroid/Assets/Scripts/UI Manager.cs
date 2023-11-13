using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Arroyo, Jordan
/// 11/13/2023
/// Script for the User Interface
/// </summary>

public class UIManager : MonoBehaviour
{

    public Player playerController;
    public TMP_Text livesText;
    public TMP_Text healthText;

   

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + playerController.lives.ToString();
        healthText.text = "Health: " + playerController.health.ToString();
    }
}
