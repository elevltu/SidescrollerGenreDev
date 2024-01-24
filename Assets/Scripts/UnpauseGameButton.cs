using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseText;
    public GameObject mainMenuButton;
    public GameObject resumeButton;
    // Start is called before the first frame update
    public void unpauseGame()
    {
        Time.timeScale = 1.0f;
        pauseText.SetActive(false); mainMenuButton.SetActive(false); resumeButton.SetActive(false);
        PauseManager.gameIsPaused = false;
    }
}
