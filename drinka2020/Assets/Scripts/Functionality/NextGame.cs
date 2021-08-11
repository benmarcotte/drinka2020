using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextGame : MonoBehaviour
{
    [SerializeField] Minigame nextMinigame;


    // Start is called before the first frame update
    void Start()
    {
        pickNextMinigame();
        StartCoroutine(scroll());
        StartCoroutine(wait(2));
    }

    IEnumerator wait(int seconds)
    {
        yield return new WaitForSecondsRealtime(seconds);
    }

    public void pickNextMinigame()
    {
        int i = UnityEngine.Random.Range(0, GameHandler.gameHandler.minigames.Length);
        nextMinigame = GameHandler.gameHandler.minigames[i];
        if (nextMinigame == GameHandler.gameHandler.activeMinigame)
        {
            i = UnityEngine.Random.Range(0, GameHandler.gameHandler.minigames.Length);
            nextMinigame = GameHandler.gameHandler.minigames[i];
        }
        GameHandler.gameHandler.activeMinigame = nextMinigame;
        nextMinigame = GameHandler.gameHandler.minigames[i];
        GameHandler.gameHandler.activeMinigame = nextMinigame;
    }

    IEnumerator scroll()
    {
        for (int i = 0; i < 30; i++)
        {
           gameObject.GetComponent<Text>().text = GameHandler.gameHandler.minigames[UnityEngine.Random.Range(0, GameHandler.gameHandler.minigames.Length)].gameName;
           yield return new WaitForSecondsRealtime(0.05f);
        }
        gameObject.GetComponent<Text>().text = nextMinigame.gameName;
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene(nextMinigame.gameName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
