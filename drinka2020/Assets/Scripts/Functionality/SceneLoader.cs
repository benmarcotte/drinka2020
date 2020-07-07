using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameHandler gameHandler;

    public void quitGame()
    {
        Application.Quit();
    }

    public void toPrepScene()
    {
        gameHandler.players = new Player[] { 
            new Player(), new Player() }; //implement controller assignment
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
        int i = UnityEngine.Random.Range(0, gameHandler.minigames.Length);
        gameHandler.activeMinigame = gameHandler.minigames[i];
        //SceneManager.LoadScene(3 + i); //to change if more functionality screens are added
        //SceneManager.LoadScene(gameHandler.activeMinigame.gameName);
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
