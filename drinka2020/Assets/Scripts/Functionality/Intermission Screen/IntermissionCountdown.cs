using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntermissionCountdown : MonoBehaviour
{
    public float initialTime;
    public float timeRemaining;
    public Text text;
    public Stopwatch timer;
    public SipCounter left;
    public SipCounter right;
    public bool started = false;
    public Text titleText;
    public Text description;
    void Start()
    {
        initialTime = (float)UnityEngine.Random.Range(8, 16);
        if (SceneLoader.sceneLoader.finalIntermissionDone)
        {
            initialTime += (float)UnityEngine.Random.Range(5, 11);
        }
        timeRemaining = initialTime;
        text = gameObject.GetComponent<Text>();
        timer = new Stopwatch();
        StartCoroutine(countdown());
        if (SceneLoader.sceneLoader.finalIntermissionDone)
        {
            titleText.text = "Final Intermission!";
            description.text = "Press a button for every sip you take!\nDrinks can go below 0!";
        }
        else
        {
            titleText.text = "Intermission";
            description.text = "Press a button for every sip you take!";
        }
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(3f);
        text.text = "3";
        yield return new WaitForSeconds(1f);
        text.text = "2";
        yield return new WaitForSeconds(1f);
        text.text = "1";
        yield return new WaitForSeconds(1f);
        timer.Start();
        started = true;
    }

    public IEnumerator endSequences()
    {
        yield return new WaitForSeconds(2.5f);
        if (SceneLoader.sceneLoader.finalIntermissionDone)
        {
            SceneLoader.sceneLoader.toNextScreen();
        }
        else
        {
            SceneManager.LoadScene("Next Game");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            timeRemaining = (initialTime - ((float)(timer.ElapsedMilliseconds / 1000f)));
            text.text = timeRemaining.ToString("F2");
        }
        if (timeRemaining <= 0f)
        {
            text.fontSize = 30;
            text.text = "Intermission over!";
            if (started)
            {
                StartCoroutine(endSequences());
            }
            started = false;
        }
        if (!SceneLoader.sceneLoader.finalIntermissionDone)
        {
            if(GameHandler.gameHandler.leftPlayer.drinks < 0)
            {
                GameHandler.gameHandler.leftPlayer.drinks = 0;
            }
            if(GameHandler.gameHandler.rightPlayer.drinks < 0)
            {
                GameHandler.gameHandler.rightPlayer.drinks = 0;
            }
            if (GameHandler.gameHandler.rightPlayer.drinks == 0 && GameHandler.gameHandler.leftPlayer.drinks == 0)
            {
                started = false;
                StartCoroutine(endSequences());
                titleText.text = "Both players finished their drinks!";
            }
        }
    }
}
