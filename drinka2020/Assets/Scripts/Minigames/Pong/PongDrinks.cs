using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongDrinks : MonoBehaviour
{
    public Text text;
    public Player side;
    
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        if(gameObject.tag.Equals("Left"))
        {
            side = GameHandler.gameHandler.leftPlayer;
        }
        else
        {
            side = GameHandler.gameHandler.rightPlayer;
        }
    }

    public void tying()
    {
        text.text += "Tied! +1\n";
        side.drinks += 1;
        StartCoroutine(wait());
    }

    public void losing()
    {
        text.text += "Losing! +2\n";
        side.drinks += 2;
        StartCoroutine(wait());
    }

    public void lostRound()
    {
        text.text += "Lost the round! +3\n";
        side.drinks += 3;
        StartCoroutine(wait());
    }

    public void Pong()
    {
        text.text += "Pong +1\n";
        side.drinks += 1;
        StartCoroutine(wait());
    }

    public void lostMatch()
    {
        text.text += "Lost the match! +5\n";
        side.drinks += 5;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.75f);
        text.text = text.text.Substring(text.text.IndexOf('\n') + 1);
    }
   
}