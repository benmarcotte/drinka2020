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
        int i = UnityEngine.Random.Range(0, GameHandler.gameHandler.minigames.Length);
        GameHandler.gameHandler.activeMinigame = GameHandler.gameHandler.minigames[i];
        //SceneManager.LoadScene(3 + i); //to change if more functionality screens are added
        //SceneManager.LoadScene(GameHandler.gameHandler.activeMinigame.gameName);
        //Going to implement first screen, probably with a 3-2-1
        SceneManager.LoadScene("Next Game");
    }

    public void toNextScreen()
    {
        SceneManager.LoadScene("Next Game");
    }

    internal static void toIntermissionScene()
    {
        throw new NotImplementedException();
    }
}
