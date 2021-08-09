using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CountdownRPS : MonoBehaviour
{
    public float initialTime;
    public float timeRemaining;
    public Text text;
    public Stopwatch timer;
    public bool started = false;
    void Start()
    {
        initialTime = 3f;
        timeRemaining = initialTime;
        text = gameObject.GetComponent<Text>();
        timer = new Stopwatch();
        text.enabled = false;
        StartCoroutine(countdown());
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(2f);
        text.enabled = true;
        text.text = "3";
        yield return new WaitForSeconds(1f);
        text.text = "2";
        yield return new WaitForSeconds(1f);
        text.text = "1";
        yield return new WaitForSeconds(1f);
        timer.Start();
        RPSHandler.rpsHandler.startRound();
        started = true;
    }

    public void stop()
    {
        timer.Stop();
        started = false;
    }

    public void reset()
    {
        timeRemaining = initialTime;
        timer.Restart();
        RPSHandler.rpsHandler.startRound();
        timer.Start();
        started = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            timeRemaining = (initialTime - ((float)(timer.ElapsedMilliseconds / 1000f)));
            text.text = timeRemaining.ToString("F2");
            RPSHandler.rpsHandler.status.text = "Make your choice!";
        }
        if (timeRemaining <= 0f)
        {
            if (!RPSHandler.rpsHandler.resolved)
            {
                text.fontSize = 30;
                text.text = "Round over!";
                RPSHandler.rpsHandler.resolveRound();
                RPSHandler.rpsHandler.resolved = true;
                started = false;
            }
        }
    }
}
