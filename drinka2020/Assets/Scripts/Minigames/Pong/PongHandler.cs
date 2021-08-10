using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongHandler : MonoBehaviour, IHandler
{
    public Image leftPaddle;
    public Image rightPaddle;
    public Image ball;
    [SerializeField] public BallPong gameBall;
    public int leftScore = 0;
    public int rightScore = 0;
    [SerializeField] public PongDrinks leftDrinks;
    [SerializeField] public PongDrinks rightDrinks;
    public static PongHandler pongHandler;
    public bool winnerDeclared = false;
    [SerializeField] Text leftScoreText;
    [SerializeField] Text rightScoreText;


    void Start()
    {
        pongHandler = gameObject.GetComponent<PongHandler>();
        leftPaddle.color = GameHandler.gameHandler.leftPlayer.color;
        rightPaddle.color = GameHandler.gameHandler.rightPlayer.color;
        //drinks();
    }

    public static void Score(string wallID)
    {
        if (wallID.Equals("Right wall"))
        {
            pongHandler.leftScore++;
            pongHandler.rightDrinks.lostRound();
            if(pongHandler.leftScore >= 3)
            {
                pongHandler.rightDrinks.lostMatch();
                pongHandler.declareWinner('L');
            }
        }
        else
        {
            pongHandler.rightScore++;
            pongHandler.leftDrinks.lostRound();
            if (pongHandler.rightScore >= 3)
            {
                pongHandler.leftDrinks.lostMatch();
                pongHandler.declareWinner('R');
            }
        }       
    }

    private void declareWinner(char v)
    {
        if(v == 'L')
        {
            gameObject.GetComponent<Text>().text = "PONG\n" + GameHandler.gameHandler.leftPlayer.playerName + " wins!";
        } 
        else
        {
            gameObject.GetComponent<Text>().text = "PONG\n" + GameHandler.gameHandler.rightPlayer.playerName + " wins!";
        }
        Destroy(gameBall.gameObject);
        Invoke("minigameEnd", 3f);
    }

    public void minigameEnd()
    {
        GameHandler.gameHandler.minigameEnd();
    }

    //public IEnumerator drinks()
    //{
    //    while (true)
    //    { 
    //        while (gameBall.inPlay)
    //        {
    //            if (leftScore == rightScore)
    //            {
    //                leftDrinks.tying();
    //                rightDrinks.tying();
    //                GameHandler.gameHandler.leftPlayer.drinks++;
    //                GameHandler.gameHandler.rightPlayer.drinks++;
    //            }
    //            else if (leftScore > rightScore)
    //            {
    //                rightDrinks.losing();
    //                GameHandler.gameHandler.rightPlayer.drinks += 1;
    //            }
    //            else if (rightScore > leftScore)
    //            {
    //                leftDrinks.losing();
    //                GameHandler.gameHandler.leftPlayer.drinks += 1;
    //            }
    //            yield return new WaitForSeconds(2f);
    //        }
    //    }
    //}

    void Update()
    {
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }


}
