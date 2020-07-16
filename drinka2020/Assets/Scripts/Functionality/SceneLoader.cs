using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void quitGame()
    {
        Application.Quit();
    }

    public void toPrepScene()
    {
        SceneManager.LoadScene(1);
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void toSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }

    public void startGame()
    {
        SceneManager.LoadScene(GameHandler.gameHandler.activeMinigame.gameName);
    }

    public void toNextScreen()
    {
        if((GameHandler.gameHandler.leftPlayer.drinks > 10 || GameHandler.gameHandler.rightPlayer.drinks > 10) && UnityEngine.Random.Range(0, 1) == 1)
        {
            SceneManager.LoadScene("Intermission");
        }
        SceneManager.LoadScene("Next Game");
    }

    internal static void toIntermissionScene()
    {
        throw new NotImplementedException();
    }
}
