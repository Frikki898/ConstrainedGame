using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    System.TimeSpan timeSpan;
    private float timeLeft;
    private Text timer;

    private void Start()
    {
        timer = GetComponent<Text>();
        timeLeft = 120.0f;
        timeSpan = System.TimeSpan.FromSeconds(timeLeft);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeSpan = System.TimeSpan.FromSeconds(timeLeft);
        timer.text = timeSpan.Minutes.ToString() + ":" + timeSpan.Seconds.ToString();
        if (timeLeft < 0)
        {
            SceneManager.LoadSceneAsync("Game Over");
        }

    }
}
