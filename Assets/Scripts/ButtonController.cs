using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
   public GameController mGameController;

   public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        mGameController.togglePauseState();
        GameController.PlayerScore1 = 0;
        GameController.PlayerScore2 = 0;
        GameController.getBall().SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
    }
}
