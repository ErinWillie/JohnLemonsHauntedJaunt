using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    public float maxTime = 120f; // Maximum time in seconds
    private float currentTime;

    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        currentTime = maxTime;
        UpdateTimerDisplay();
    }

    public void UpdateTimer(float deltaTime)
    {
        currentTime -= deltaTime;

        if (currentTime <= 0f)
        {
            // Time is up, handle game over logic here
            Debug.Log("Game Over - Time's up!");
            // For example, you can call the CaughtPlayer() method in the GameEnding script
            // to trigger the game over screen with the caught animation.
            FindObjectOfType<GameEnding>().CaughtPlayer();
        }

        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        // Format the time and update the TextMeshPro text
        textMeshPro.text = $"Time: {Mathf.CeilToInt(currentTime)}";
    }
}
