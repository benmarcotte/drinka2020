using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTugOfWar : MonoBehaviour
{
    public float initialTime;
    public float timeRemaining;
    public Text text;
    public Stopwatch timer;
    public bool started = false;
    public static CountdownTugOfWar countdownTugOfWar;
    void Start()
    {
        countdownTugOfWar = gameObject.GetComponent<CountdownTugOfWar>();
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
        TugOfWarHandler.tugOfWarHandler.StartCoroutine(TugOfWarHandler.tugOfWarHandler.drinks());
    }

    public IEnumerator endSequences()
    {
        yield return new WaitForSeconds(2.5f);
        GameHandler.gameHandler.minigameEnd();
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
            text.text = "Tug of War finished!";
            if (!TugOfWarHandler.tugOfWarHandler.winnerDeclared)
            {
                TugOfWarHandler.tugOfWarHandler.winnerDeclared = true;
                if (TugOfWarHandler.tugOfWarHandler.ropePos > 0)
                {
                    TugOfWarHandler.tugOfWarHandler.gameObject.GetComponent<Text>().text = GameHandler.gameHandler.rightPlayer.playerName + " won the Tug of War!";
                    GameHandler.gameHandler.leftPlayer.drinks += 3;
                    TugOfWarHandler.tugOfWarHandler.leftDrinks.lostByTimeout();
                }
                else if (TugOfWarHandler.tugOfWarHandler.ropePos < 0)
                {
                    TugOfWarHandler.tugOfWarHandler.gameObject.GetComponent<Text>().text = GameHandler.gameHandler.leftPlayer.playerName + " won the Tug of War!";
                    GameHandler.gameHandler.rightPlayer.drinks += 3;
                    TugOfWarHandler.tugOfWarHandler.rightDrinks.lostByTimeout();
                }
                else if (TugOfWarHandler.tugOfWarHandler.ropePos == 0)
                {
                    TugOfWarHandler.tugOfWarHandler.gameObject.GetComponent<Text>().text = "Tie!";
                    GameHandler.gameHandler.rightPlayer.drinks += 10;
                    GameHandler.gameHandler.leftPlayer.drinks += 10;
                    TugOfWarHandler.tugOfWarHandler.leftDrinks.tied();
                    TugOfWarHandler.tugOfWarHandler.rightDrinks.tied();
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
