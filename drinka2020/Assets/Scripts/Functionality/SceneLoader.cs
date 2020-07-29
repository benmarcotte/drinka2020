using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
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
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(GameHandler.gameHandler.activeMinigame.gameName));
    }

    public static void toNextScreen()
    {
        if((GameHandler.gameHandler.leftPlayer.drinks > GameHandler.gameHandler.sipThreshold || GameHandler.gameHandler.rightPlayer.drinks > GameHandler.gameHandler.sipThreshold) && UnityEngine.Random.Range(0, 1) == 1)
        {
            SceneManager.LoadScene("Intermission");
        }
        else
        {
            SceneManager.LoadScene("Next Game");
        }
    }

    public static void toWinScene()
    {
        SceneManager.LoadScene("win");
    }
}
