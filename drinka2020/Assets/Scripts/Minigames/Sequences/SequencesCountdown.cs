using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class SequencesCountdown : MonoBehaviour
{
    public float initialTime;
    public float timeRemaining;
    public Text text;
    public Stopwatch timer;
    public SequencesPanel left;
    public SequencesPanel right;
    public bool started = false;
    public static SequencesCountdown sequencesCountdown;
    void Start()
    {
        sequencesCountdown = gameObject.GetComponent<SequencesCountdown>();
        initialTime = (float)Random.Range(10, 18);
        timeRemaining = initialTime;
        text = gameObject.GetComponent<Text>();
        timer = new Stopwatch();
        StartCoroutine(countdown());
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
        StartCoroutine(left.setup());
        StartCoroutine(right.setup());
        timer.Start();
        started = true;
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
            text.text = "Sequences done!";
            if (started)
            {
                StartCoroutine(endSequences());
            }
            started = false;
        }
    }
}
