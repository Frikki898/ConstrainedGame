using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int player1Score;
    public int player2Score;

    public GameObject left;
    public GameObject right;

    // Update is called once per frame
    void Update()
    {
        left.GetComponent<TextMeshProUGUI>().SetText(player1Score.ToString());
        right.GetComponent<TextMeshProUGUI>().SetText(player2Score.ToString());
    }
}

