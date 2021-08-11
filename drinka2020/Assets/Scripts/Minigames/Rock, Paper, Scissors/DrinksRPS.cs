using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinksRPS : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    public void lostRound()
    {
        text.text += "Lost round! +2\n";
        StartCoroutine(wait());
    }

    public void lostGame()
    {
        text.text += "Lost the game! +5\n";
        StartCoroutine(wait());
    }

    public void tied()
    {
        text.text += "Tied! +1\n";
        StartCoroutine(wait());
    }

    public void lostByTimeout()
    {
        text.text += "Lost by timeout! +3\n";
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.75f);
        text.text = text.text.Substring(text.text.IndexOf('\n') + 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    internal void rocheRocheRoche()
    {
        text.text += "Roche Roche Roche! +3\n";
        StartCoroutine(wait());
    }
}
