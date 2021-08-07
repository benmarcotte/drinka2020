using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongHandler : MonoBehaviour
{
    public Image leftPaddle;
    public Image rightPaddle;
    public Image ball;
    public CountdownPong countdown;
    public int leftScore = 0;
    public int rightScore = 0;
    public PongDrinks leftDrinks;
    public PongDrinks rightDrinks;
    public static PongHandler pongHandler;
    public bool winnerDeclared = false;
    
    void Start()
    {
        pongHandler = gameObject.GetComponent<PongHandler>();
        leftPaddle.color = GameHandler.gameHandler.leftPlayer.color;
        rightPaddle.color = GameHandler.gameHandler.rightPlayer.color;
    }

    public static void Score(string wallID)
    {
        if (wallID == "Right wall")
        {
            pongHandler.leftScore++;
        }
        else
        {
            pongHandler.rightScore++;
        }
    }

    public IEnumerator drinks()
    {
        while (countdown.started)
        {
            if (leftScore == rightScore)
            {
                leftDrinks.timePassed();
                rightDrinks.timePassed();
                GameHandler.gameHandler.leftPlayer.drinks++;
                GameHandler.gameHandler.rightPlayer.drinks++;
            }
            else if (leftScore > rightScore)
            {
                rightDrinks.soClose();
                leftDrinks.timePassed();
                GameHandler.gameHandler.rightPlayer.drinks += 2;
                GameHandler.gameHandler.leftPlayer.drinks++;
            }
            else if (rightScore > leftScore)
            {
                leftDrinks.soClose();
                rightDrinks.timePassed();
                GameHandler.gameHandler.leftPlayer.drinks += 2;
                GameHandler.gameHandler.rightPlayer.drinks++;
            }
            yield return new WaitForSeconds(1.5f);
        }
    }

    void Update()
    {
        
    }


}
