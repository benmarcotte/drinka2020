using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class WarHandler : MonoBehaviour
{
    public CardStack initial;
    public CardStack right;
    public CardStack left;
    public CardStack rightInPlay;
    public CardStack leftInPlay;
    public CardStack warRight;
    public CardStack warLeft;
    public CardStack wonLeft;
    public CardStack wonRight;
    public Card rightCard;
    public Card leftCard;
    public bool dealt = false;
    public bool started = false;
    //public bool winnerDeclared = false;
    public int scoreLimit;
    public Text scoreLeft;
    public Text scoreRight;
    public int diff;
    public WarDrinks leftDrinks;
    public WarDrinks rightDrinks;
    public bool atWar = false;

    // Start is called before the first frame update
    void Awake()
    {

    }

    private void Start()
    {
        scoreLimit = UnityEngine.Random.Range(2, 5) * 2;
        StartCoroutine(deal());
    }

    IEnumerator deal()
    {
        yield return new WaitForSeconds(0.5f);
        initial.Shuffle();
        int i = 0;
        while (initial.cards.Count > 0)
        {
            if (i % 2 == 0)
            {
                initial.
                    topCard.sendToStack(
                    left);
            }
            else
            {
                initial.topCard.sendToStack(
                    right);
            }
            i++;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(1f);
        dealt = true;
        StartCoroutine(war());
    }

    IEnumerator war()
    {
        scoreLeft.enabled = true;
        scoreRight.enabled = true;
        leftDrinks.GetComponent<Text>().enabled = true;
        rightDrinks.GetComponent<Text>().enabled = true;
        diff = 0;
        while (true)
        {
            //if (wonLeft.cards.Count >= scoreLimit)
            //{
            //    GameHandler.gameHandler.leftPlayer.score++;
            //    GameHandler.gameHandler.minigameEnd();
            //}
            //else if (wonRight.cards.Count >= scoreLimit)
            //{
            //    GameHandler.gameHandler.rightPlayer.score++;
            //    GameHandler.gameHandler.minigameEnd();
            //}
            right.topCard.sendToStack(rightInPlay);
            left.topCard.sendToStack(leftInPlay);
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            rightInPlay.topCard.reveal();
            leftInPlay.topCard.reveal();
            yield return new WaitForSeconds(1f);

            if (rightInPlay.topCard.value == 14)
            {
                rightDrinks.drewJoker();
                GameHandler.gameHandler.rightPlayer.drinks += 5;
            }

            if (leftInPlay.topCard.value == 14)
            {
                leftDrinks.drewJoker();
                GameHandler.gameHandler.leftPlayer.drinks += 5;
            }

            if (rightInPlay.topCard.value > leftInPlay.topCard.value)
            {
                while (warRight.cards.Count > 0)
                {
                    warRight.topCard.sendToStack(wonRight);
                    yield return new WaitForEndOfFrame();
                    diff++;
                }
                while (warLeft.cards.Count > 0)
                {
                    warLeft.topCard.sendToStack(wonRight);
                    yield return new WaitForEndOfFrame();
                    diff++;
                }
                leftInPlay.topCard.sendToStack(wonRight);
                rightInPlay.topCard.sendToStack(wonRight);
                if (atWar)
                {
                    leftDrinks.lostWar(diff);
                    leftDrinks.lost();
                    GameHandler.gameHandler.leftPlayer.drinks += diff;
                    GameHandler.gameHandler.leftPlayer.drinks++;
                    atWar = false;
                    diff = 0;
                }
                else
                {
                    leftDrinks.lost();
                    GameHandler.gameHandler.leftPlayer.drinks++;
                }
            }
            else if (leftInPlay.topCard.value > rightInPlay.topCard.value)
            {
                while (warRight.cards.Count > 0)
                {
                    warRight.topCard.sendToStack(wonLeft);
                    yield return new WaitForEndOfFrame();
                    diff++;
                }
                while (warLeft.cards.Count > 0)
                {
                    warLeft.topCard.sendToStack(wonLeft);
                    yield return new WaitForEndOfFrame();
                    diff++;
                }
                leftInPlay.topCard.sendToStack(wonLeft);
                rightInPlay.topCard.sendToStack(wonLeft);
                if (atWar)
                {
                    rightDrinks.lostWar(diff);
                    rightDrinks.lost();
                    GameHandler.gameHandler.rightPlayer.drinks += diff;
                    GameHandler.gameHandler.rightPlayer.drinks++;
                    atWar = false;
                    diff = 0;
                }
                else
                {
                    rightDrinks.lost();
                    GameHandler.gameHandler.rightPlayer.drinks++;
                }
            }
            else
            {
                rightInPlay.topCard.sendToStack(warRight);
                leftInPlay.topCard.sendToStack(warLeft);
                atWar = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(dealt && !started)
        //{
        //    started = true;
        //    StartCoroutine(war());
        //}
    }
}
