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
        SceneManager.LoadScene(0);
    }

    public void toSettingsScene()
    {
        SceneManager.LoadScene(2);
    }

    public void startGame()
    {
        //to implement
    }

    internal static void toIntermissionScene()
    {
        throw new NotImplementedException();
    }
}
