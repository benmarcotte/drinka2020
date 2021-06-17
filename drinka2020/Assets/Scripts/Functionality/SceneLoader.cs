using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader sceneLoader;
    public bool finalIntermissionDone = false;
    private void Awake()
    {
        int sceneLoaderCount = FindObjectsOfType<SceneLoader>().Length;
        if (sceneLoaderCount> 1)
        {
            Destroy(gameObject);
        }
        else
        {
            sceneLoader = gameObject.GetComponent<SceneLoader>();
            DontDestroyOnLoad(gameObject);
        }
    }
    public void quitGame()
    {
        Application.Quit();
    }

    public void toPrepScene()
    {
        SceneManager.LoadScene("Prep Screen");
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        for(int i = 0; i < GameHandler.gameHandler.players.Length; i++)
        {
            GameHandler.gameHandler.players[i].initialize();
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
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

    public void toNextScreen()
    {
        if (finalIntermissionDone)
        {
            if (GameHandler.gameHandler.leftPlayer.drinks > GameHandler.gameHandler.rightPlayer.drinks)
            {
                GameHandler.gameHandler.win(GameHandler.gameHandler.rightPlayer);
            }
            else
            {
                GameHandler.gameHandler.win(GameHandler.gameHandler.leftPlayer);
            }
        }
        else if (GameHandler.gameHandler.leftPlayer.drinks > 40 || GameHandler.gameHandler.rightPlayer.drinks > 40)
        {
            finalIntermissionDone = true;
            SceneManager.LoadScene("Intermission");
        }
        else if (UnityEngine.Random.Range(0, 2) == 1 || ((GameHandler.gameHandler.leftPlayer.drinks > 30 || GameHandler.gameHandler.rightPlayer.drinks > 30) && UnityEngine.Random.Range(0, 2) == 1))
        {
            SceneManager.LoadScene("Intermission");
        }
        else
        {
            SceneManager.LoadScene("Next Game");
        }
        //    {
        //    GameHandler.gameHandler.rounds++;
        //    if (GameHandler.gameHandler.rounds >= 4)
        //    {
        //if (finalIntermissionDone)
        //{
        //    if (GameHandler.gameHandler.leftPlayer.drinks > GameHandler.gameHandler.rightPlayer.drinks)
        //    {
        //        GameHandler.gameHandler.win(GameHandler.gameHandler.rightPlayer);
        //    }
        //    else
        //    {
        //        GameHandler.gameHandler.win(GameHandler.gameHandler.leftPlayer);
        //    }
        //}
        //        else
        //        }
        //    }
        //    else
        //    {
        //        SceneManager.LoadScene("Next Game");
        //    }
        //}
    }


    public void toWinScene()
    {
        SceneManager.LoadScene("win");
    }
}
