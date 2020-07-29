using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CardStack : MonoBehaviour
{
    public LinkedList<Card> cards;
    public Player player;
    public Card topCard;
    public Card[] cardArr;
    public bool revealed = false;
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Image background;
    public Sprite back;
    public bool usePlayerColor;
    public bool isLeftPlayer;
    public bool findPlayer;
    // Start is called before the first frame update
    private void Awake()
    {
        cards = new LinkedList<Card>();
    }

    void Start()
    {
        if (findPlayer)
        {
            if (isLeftPlayer)
            {
                player = GameHandler.gameHandler.leftPlayer;
            }
            else
            {
                player = GameHandler.gameHandler.rightPlayer;
            }
        }
        back = Resources.Load<Sprite>("Sprites/Cards/back");
        Card[] cardArr = GetComponentsInChildren<Card>();
        for (int i = 0; i < cardArr.Length; i++)
        {
            cardArr[i].image.enabled = false;
            cardArr[i].background.enabled = false;
            cards.AddLast(cardArr[i]);
        }
        if(cards.Count > 0)
        {
            topCard = cards.First.Value;
        }
        cardArr = new Card[cards.Count];
    }

    public void Shuffle()
    {
        cards.CopyTo(cardArr, 0);
        for (int i = 0; i < cardArr.Length; i++)
        {
            Card temp = cardArr[i];
            int randomIndex = UnityEngine.Random.Range(i, cardArr.Length);
            cardArr[i] = cardArr[randomIndex];
            cardArr[randomIndex] = temp;
        }
        cards.Clear();
        for (int i = 0; i < cardArr.Length; i++)
        {
            cardArr[i].image.enabled = false;
            cardArr[i].background.enabled = false;
            cards.AddFirst(cardArr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (cards.Count > 0)
        {
            topCard = cards.First.Value;
            topCard.image.enabled = true;
            topCard.background.enabled = true;
            background = topCard.background;
        }
        
        GetComponent<Image>().enabled = false;
        GetComponentInChildren<Image>().enabled = false;
        cardArr = new Card[cards.Count];
        cards.CopyTo(cardArr, 0);
        for (int i = 0; i < cardArr.Length; i++)
        {
            cardArr[i].stack = GetComponent<CardStack>();
        }
    }
}
