using System.Collections;
using System.Collections.Generic;

public static class CrossSceneRegistry
{
    public static int PlayerOneScore
    {
        get
        {
            return playerOneScore;
        }
        set
        {
            playerOneScore = value;
        }
    }

    public static int PlayerTwoScore
    {
        get
        {
            return playerTwoScore;
        }
        set
        {
            playerTwoScore = value;
        }
    }

    private static int playerOneScore = 0;
    private static int playerTwoScore = 0;


}
