using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneButtonCodeStuffs : MonoBehaviour
{
    public string sceneName;
    public void loadScene(){
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneName);
    }
}
