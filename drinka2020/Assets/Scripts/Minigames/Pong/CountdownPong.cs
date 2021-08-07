
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class CountdownPong : MonoBehaviour
{
    public float initialTime;
    public float timeRemaining;
    public Text text;
    public Stopwatch timer;
    public bool started = false;
    public static CountdownPong countdownPong;
    
    void Start()
    {
        countdownPong = gameObject.GetComponent<CountdownPong>();
        initialTime = (float)Random.Range(8, 16);
        timeRemaining = initialTime;
        text = gameObject.GetComponent<Text>();
        timer = new Stopwatch();
        text.enabled = false;
        StartCoroutine(countdown());
    }
    IEnumerator countdown()
    {
        yield return new WaitForSeconds(3f);
        text.enabled = true;
        text.text = "3";
        yield return new WaitForSeconds(1f);
        text.text = "2";
        yield return new WaitForSeconds(1f);
        text.text = "1";
        yield return new WaitForSeconds(1f);
        timer.Start();
        started = true;
        PongHandler.pongHandler.StartCoroutine(PongHandler.pongHandler.drinks());
    }

    public IEnumerator endSequences()
    {
        yield return new WaitForSeconds(2.5f);
        GameHandler.gameHandler.minigameEnd();
    }
    
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
            text.text = "Pong game over!";
            if (!PongHandler.pongHandler.winnerDeclared)
            {
                PongHandler.pongHandler.winnerDeclared = true;
                if (PongHandler.pongHandler.leftScore > 0)
                {
                    PongHandler.pongHandler.gameObject.GetComponent<Text>().text = "Right side won the Pong!";
                    GameHandler.gameHandler.leftPlayer.drinks += 5;
                    PongHandler.pongHandler.leftDrinks.lost();
                }
                else if (PongHandler.pongHandler.rightScore < 0)
                {
                    PongHandler.pongHandler.gameObject.GetComponent<Text>().text = "Left side won the Pong!";
                    GameHandler.gameHandler.rightPlayer.drinks += 5;
                    PongHandler.pongHandler.rightDrinks.lost();
                }
                else if (PongHandler.pongHandler.leftScore == 0 && PongHandler.pongHandler.rightScore == 0)
                {
                    PongHandler.pongHandler.gameObject.GetComponent<Text>().text = "Tie!";
                    GameHandler.gameHandler.rightPlayer.drinks += 10;
                    GameHandler.gameHandler.leftPlayer.drinks += 10;
                    PongHandler.pongHandler.leftDrinks.tied();
                    PongHandler.pongHandler.rightDrinks.tied();
                }
            }

            if (started)
            {
                StartCoroutine(endSequences());
            }
            started = false;
        }
    }
}
