using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongDrinks : MonoBehaviour, IDrinkStatus
{
    public Text _text;
    public Player side;

    public Text Text { get => _text; set => _text = value; }

    // Start is called before the first frame update
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
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
        _text.text += "Tied! +1\n";
        side.drinks += 1;
        StartCoroutine(wait());
    }

    public void losing()
    {
        _text.text += "Losing! +2\n";
        side.drinks += 2;
        StartCoroutine(wait());
    }

    public void lostRound()
    {
        _text.text += "Lost the round! +3\n";
        side.drinks += 3;
        StartCoroutine(wait());
    }

    public void Pong()
    {
        _text.text += "Pong +1\n";
        side.drinks += 1;
        StartCoroutine(wait());
    }

    public void lostMatch()
    {
        _text.text += "Lost the match! +5\n";
        side.drinks += 5;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.75f);
        _text.text = _text.text.Substring(_text.text.IndexOf('\n') + 1);
    }
   
}