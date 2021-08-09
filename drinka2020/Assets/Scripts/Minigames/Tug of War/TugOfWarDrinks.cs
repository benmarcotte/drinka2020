using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TugOfWarDrinks : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    public void timePassed()
    {
        text.text += "Surviving! +1\n";
        StartCoroutine(wait());
    }

    public void gettingPulled()
    {
        text.text += "Getting pulled! +2\n";
        StartCoroutine(wait());
    }

    public void tied()
    {
        text.text = "Tied! +10\n";
    }

    public void lostTugOfWar()
    {
        text.text = "Lost Tug of War! +5\n";
    }

    public void lostByTimeout()
    {
        text.text = "Lost Tug of War by timeout! +3\n";
    }

    public void inDanger()
    {
        text.text += "In danger! +1\n";
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
}
