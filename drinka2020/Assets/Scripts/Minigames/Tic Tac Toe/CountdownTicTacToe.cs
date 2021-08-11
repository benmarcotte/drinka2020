using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTicTacToe : MonoBehaviour
{
    public float initialTime;
    public float timeRemaining;
    public Text text;
    public Stopwatch timer;
    public bool started = false;
    public static CountdownTugOfWar countdownTugOfWar;
    [SerializeField] public TicTacToeBoard board;
    void Start()
    {
        countdownTugOfWar = gameObject.GetComponent<CountdownTugOfWar>();
        initialTime = 3f;
        timeRemaining = initialTime;
        text = gameObject.GetComponent<Text>();
        timer = new Stopwatch();
        text.enabled = false;
        StartCoroutine(countdown());
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(0.5f);
        text.enabled = true;
        text.text = "3";
        yield return new WaitForSeconds(1f);
        text.text = "2";
        yield return new WaitForSeconds(1f);
        text.text = "1";
        yield return new WaitForSeconds(1f);
        timer.Start();
        started = true;
    }

    public void resetTimer()
    {
        timer.Restart();
        timeRemaining = initialTime;
        started = true;
    }

    public void Stop()
    {
        timer.Stop();
        started = false;
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
            if (started)
            {
                board.changeTurn(true);
            }
        }
    }
}
