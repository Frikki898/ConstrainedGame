using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreManager : MonoBehaviour
{
    public Text playerOneScore;
    public Text playerTwoScore;

    // Start is called before the first frame update
    void Start()
    {
        playerOneScore.text = CrossSceneRegistry.PlayerOneScore.ToString();
        playerTwoScore.text = CrossSceneRegistry.PlayerTwoScore.ToString();
    }
    
}
