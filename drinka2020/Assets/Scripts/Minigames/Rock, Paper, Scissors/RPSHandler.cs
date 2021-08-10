using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPSHandler : MonoBehaviour, IHandler
{
    [SerializeField] public Hand left;
    [SerializeField] DrinksRPS leftDrinks;
    public int leftScore = 0;
    [SerializeField] Text leftScoreText;
    [SerializeField] public Hand right;
    [SerializeField] DrinksRPS rightDrinks;
    [SerializeField] Text rightScoreText;
    public int rightScore = 0;
    [SerializeField] public Text status;
    [SerializeField] CountdownRPS countdown;
    [SerializeField] public static RPSHandler rpsHandler;
   
    public bool resolved = false;


    
    // Start is called before the first frame update
    void Start()
    {
        rpsHandler = gameObject.GetComponent<RPSHandler>();
        left.img.color = GameHandler.gameHandler.leftPlayer.color;
        right.img.color = GameHandler.gameHandler.rightPlayer.color;
    }

    public void startRound()
    {
        left.canChoose = true;
        right.canChoose = true;
    }

    public void resolveRound()
    {
        left.canChoose = false;
        right.canChoose = false;
        if(left.choice == Hand.Options.none || right.choice == Hand.Options.none)
        {
            if(left.choice == Hand.Options.none)
            {
                leftDrinks.lostByTimeout();
                GameHandler.gameHandler.leftPlayer.drinks += 3;
            }
            if (right.choice == Hand.Options.none)
            {
                rightDrinks.lostByTimeout();
                GameHandler.gameHandler.rightPlayer.drinks += 3;
            }
        }
        //is a draw
         else if (left.choice == right.choice) {
            status.GetComponent<Text>().text= "Draw!";
            leftDrinks.tied();
            rightDrinks.tied();
            GameHandler.gameHandler.leftPlayer.drinks += 1;
            GameHandler.gameHandler.rightPlayer.drinks += 1;
        }

        //left wins
        else if(((left.choice == Hand.Options.rock) && (right.choice == Hand.Options.scissors) ||
            ((left.choice == Hand.Options.scissors) && (right.choice == Hand.Options.paper)) ||
            ((left.choice == Hand.Options.paper) && (right.choice == Hand.Options.rock))))
        {
            status.GetComponent<Text>().text= "Left wins!";
            rightDrinks.lostRound();
            GameHandler.gameHandler.rightPlayer.drinks += 2;
            leftScore++;
        }

        //right wins
        else 
        {
            status.GetComponent<Text>().text= "Right wins!";
            leftDrinks.lostRound();
            GameHandler.gameHandler.leftPlayer.drinks += 2;
            rightScore++;
        }
        left.img.enabled = true;
        right.img.enabled = true;
        if(rightScore >= 3)
        {
            declareWinner('r');
        }
        else if(leftScore >= 3)
        {
            declareWinner('l');
        }
        else
        {
            Invoke("ResetRound", 2f);
        }
    }

    public void declareWinner(char c)
    {
        if (c == 'r')
        {
            status.text = GameHandler.gameHandler.rightPlayer.playerName + " wins the game!";
        } 
        else 
        {
            status.text = GameHandler.gameHandler.leftPlayer.playerName + " wins the game!";
        }

        Invoke("endMinigame", 3f);
    }

    private void ResetRound()
    {
        status.text = "";
        left.choice = Hand.Options.none;
        right.choice = Hand.Options.none;
        left.img.enabled = false;
        left.img.sprite = left.none;
        right.img.enabled = false;
        right.img.sprite = right.none;
        left.chosen = false;
        left.canChoose = false;
        right.chosen = false;
        right.canChoose = false;
        resolved = false;
        countdown.reset();
    }

    void endMinigame()
    {
        GameHandler.gameHandler.minigameEnd();
    }

    // Update is called once per frame
    void Update()
    {
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
        if (left.chosen && right.chosen && !resolved)
        {
            resolveRound();
            countdown.stop();
            resolved = true;
        }
    }
}
