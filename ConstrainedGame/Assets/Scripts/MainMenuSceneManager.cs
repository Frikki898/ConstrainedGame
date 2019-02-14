using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneManager : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("clicked play");
        SceneManager.LoadSceneAsync("MainScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
