using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarDrinks : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void fumbled()
    {
        text.text += "Fumbled! +1\n";
    }

    public void didNothing()
    {
        text.text += "Did nothing! +1\n";
        StartCoroutine(wait());
    }
    
    public void bothSuck()
    {
        text.text += "Both players failed! +3\n";
        StartCoroutine(wait());
    }

    public void lost()
    {
        text.text += "Lost! +2\n";
        StartCoroutine(wait());
    }

    public void lostWar()
    {
        text.text += "Lost the war! +5\n";
        StartCoroutine(wait());
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(1.2f);
        text.text = "";
    }

    public void drewJoker()
    {
        text.text += "Drew Joker! +5\n";
        StartCoroutine(wait());
    }

    public void lostWar(int count)
    {
        text.text += text.text + "Lost war! +" + count.ToString() + "\n";
        text.text = text.text.Substring(text.text.IndexOf('\n') + 1);
    }
}
