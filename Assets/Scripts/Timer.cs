using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timer;
    public static bool hasBeenDamagedRecently;
    private bool currentlyInulnerable;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 90;
        hasBeenDamagedRecently = false;
        currentlyInulnerable = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
       
        if (hasBeenDamagedRecently)
        {
            InvulnerabilityTime();
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene("game over");
        }
    }
    async void InvulnerabilityTime()
    {
        if (!currentlyInulnerable)
        {
            currentlyInulnerable = true;
            await Task.Delay(600);
            hasBeenDamagedRecently = false;
            currentlyInulnerable = false;
        }
    }
}
