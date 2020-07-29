using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinToMainMenu : MonoBehaviour
{
    void Update()
    {
        if(GetComponentsInChildren<WinScreenCheck>()[0].confirmed && GetComponentsInChildren<WinScreenCheck>()[1].confirmed)
        {
            toMainMenu();
        }
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Destroy(GameHandler.gameHandler.leftPlayer);
        Destroy(GameHandler.gameHandler.rightPlayer);
    }
}
