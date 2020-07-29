using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    /// <summary>
    /// suit: 1-4, Heart, Spade, Club, Diamond respectively
    /// value: 1-14, 14 is joker
    /// </summary>
    public int value;
    string card;
    public int suit;
    public bool revealed = false;
    public Color color;
    public bool usePlayerColor;
    public Color playerColor;
    public Color backColor;
    Color faceColor;
    Color black = new Color(0.1f, 0.1f, 0.1f);
    Color blue = new Color(0, 0.1f, 0.9f);
    Color red = new Color(1, 0, 0);
    Color gray = new Color(0.3f, 0.3f, 0.3f);
    Color white = new Color(1, 1, 1);
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Image background;
    Sprite back;
    Sprite face;
    public CardStack stack;

    // Start is called before the first frame update
    void Start()
    {
        //image = GetComponentInChildren<UnityEngine.UI.Image>();
        back = Resources.Load<Sprite>("Sprites/Cards/back");
        if (value == 1)
        {
            card = "A";
        }
        else if (value == 11)
        {
            card = "J";
        }
        else if (value == 12)
        {
            card = "Q";
        }
        else if (value == 13)
        {
            card = "K";
        }
        else if (value == 14)
        {
            card = "O";
        }
        else
        {
            card = value.ToString();
        }

        switch (suit)
        {
            case 1:
                card += "H";
                //if (!usePlayerColor)
                faceColor = red;
                break;
            case 2:
                card += "S";
                //if (!usePlayerColor)
                faceColor = black;
                break;
            case 3:
                card += "C";
                //if (!usePlayerColor)
                faceColor = black;
                break;
            case 4:
                card += "D";
                //if (!usePlayerColor)
                faceColor = red;
                break;
        }
        face = Resources.Load<Sprite>("Sprites/Cards/" + card);
        if (!usePlayerColor)
        {
            backColor = blue;
        }
        else
        {
            backColor = playerColor;
        }
        image.sprite = back;
        //GetComponentInChildren<UnityEngine.UI.Image>().sprite = back;
        stack = GetComponentInParent<CardStack>();
    }

    void Update()
    {
        if(stack != null)
        {
            gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, stack.transform.position, 0.1f);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            if (stack.usePlayerColor)
            {
                usePlayerColor = true;
                backColor = stack.player.color;
                //faceColor = stack.player.color;
                //color = stack.player.color;
            }
        }
        if (revealed)
        {
            image.color = faceColor;
        }
        else
        {
            image.color = backColor;
        }
    }

    public void changeValue(int value, int suit)
    {
        this.value = value;
        this.suit = suit;
        Start();
    }

    public void sendToStack(CardStack destinationStack)
    {
        stack.topCard = null;
        image.enabled = true;
        background.enabled = true;
        if(stack != null)
        {
            stack.cards.Remove(GetComponent<Card>());   
        }
        stack = destinationStack;
        stack.cards.AddFirst(GetComponent<Card>());
        gameObject.transform.SetParent(destinationStack.transform);
    }

    public void flip()
    {
        if (revealed)
        {
            hide();
        }
        else
        {
            reveal();
        }
    }

    public void reveal()
    {
        revealed = true;
        color = faceColor;
        image.sprite = face;
        //GetComponentInChildren<UnityEngine.UI.Image>().sprite = face;
        adjustBackground();
    }

    public void hide()
    {
        revealed = false;
        if (usePlayerColor)
        {
            color = faceColor;
        }
        else
        {
            color = blue;
        }
        image.sprite = back;
        //GetComponentInChildren<UnityEngine.UI.Image>().sprite = back;
        adjustBackground();
    }

    void adjustBackground()
    {
        if (faceColor.r + faceColor.g + faceColor.b >= 2)
        {
            background.color = gray;
        }
        else
        {
            background.color = white;
        }
    }
}
