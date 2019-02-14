using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneManager : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadSceneAsync("MainScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
