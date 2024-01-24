using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseText;
    public GameObject mainMenuButton;
    public GameObject resumeButton;
    public static bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Time.timeScale = 1.0f;
                pauseText.SetActive(false); mainMenuButton.SetActive(false); resumeButton.SetActive(false);
                gameIsPaused = false;
            }
            else
            {
                pauseText.SetActive(true); mainMenuButton.SetActive(true); resumeButton.SetActive(true);
                Time.timeScale = 0f;
                gameIsPaused = true;
            }

        }
    }
}
