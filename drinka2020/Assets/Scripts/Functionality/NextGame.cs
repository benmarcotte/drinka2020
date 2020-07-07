using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextGame : MonoBehaviour
{
    [SerializeField] GameHandler gameHandler;
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
        int i = UnityEngine.Random.Range(0, gameHandler.minigames.Length);
        nextMinigame = gameHandler.minigames[i];
        if (nextMinigame == gameHandler.activeMinigame)
        {
            i = UnityEngine.Random.Range(0, gameHandler.minigames.Length);
            nextMinigame = gameHandler.minigames[i];
        }
        gameHandler.activeMinigame = nextMinigame;
    }

    IEnumerator scroll()
    {
        for (int i = 0; i < 20; i++)
        {
            this.GetComponent<Text>().text = gameHandler.minigames[UnityEngine.Random.Range(0, gameHandler.minigames.Length)].gameName;
           yield return new WaitForSecondsRealtime(0.1f);
        }
        this.GetComponent<Text>().text = nextMinigame.gameName;
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(nextMinigame.gameName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
