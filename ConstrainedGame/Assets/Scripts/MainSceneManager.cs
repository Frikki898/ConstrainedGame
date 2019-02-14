using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainSceneManager : MonoBehaviour
{
    bool isPaused;
    public void GoToGameOverScene()
    {
        SceneManager.LoadSceneAsync("GameOver");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync("EscapeOverlay");
            }
            else
            {
                
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync("EscapeOverlay", LoadSceneMode.Additive);
            }
            isPaused = !isPaused;
            
        }
    }

    private void Start()
    {
        CrossSceneRegistry.PlayerOneScore = 0;
        CrossSceneRegistry.PlayerTwoScore = 0;
        isPaused = false;
        Time.timeScale = 1;
    }

}
