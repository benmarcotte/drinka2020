using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongDrinks : MonoBehaviour
{
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }
    
    public void timePassed()
    {
        text.text += "Surviving! +1\n";
        StartCoroutine(wait());
    }

    public void tooSlow()
    {
        text.text += "Too slow! +3\n";
    }

    public void soClose()
    {
        text.text += "So close! +5\n";
    }

    public void tied()
    {
        text.text = "Tied! +10\n";
    }
    public void lost()
    {
        text.text += "You lost! +15\n";
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.75f);
        text.text = text.text.Substring(text.text.IndexOf('\n') + 1);
    }
   
}