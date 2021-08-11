using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeDrinks : MonoBehaviour
{

    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void tic()
    {
        text.text += "Tic! +1\n";
        StartCoroutine(wait());
    }

    internal void lost()
    {
        text.text += "Lost the game! +5\n";
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.75f);
        text.text = text.text.Substring(text.text.IndexOf('\n') + 1);
    }

    internal void timeout()
    {
        text.text += "Too slow! +2\n";
        StartCoroutine(wait());
    }

    internal void draw()
    {
        text.text += "Drew! +5\n";
    }
}
