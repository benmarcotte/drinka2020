using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class TugOfWarHandler : MonoBehaviour
{
    public Image leftImage;
    public Image rightImage;
    public CountdownTugOfWar countdown;
    public Image rope;
    public int ropePos = 0;
    public int leftPulls = 0;
    public int rightPulls = 0;
    //public PlayerControlsTugOfWar leftControls;
    //public PlayerControlsTugOfWar rightControls;
    public TugOfWarDrinks leftDrinks;
    public TugOfWarDrinks rightDrinks;
    public static TugOfWarHandler tugOfWarHandler;
    public bool winnerDeclared = false;
    public Sprite pulling;
    public Sprite desperate;
    public Sprite lost;
    public Sprite victory;
    public long framecount;

    // Start is called before the first frame update
    void Start()
    {
        tugOfWarHandler = gameObject.GetComponent<TugOfWarHandler>();
        leftImage.color = GameHandler.gameHandler.leftPlayer.color;
        rightImage.color = GameHandler.gameHandler.rightPlayer.color;
        //leftControls = GameHandler.gameHandler.leftPlayer.GetComponent<PlayerControlsTugOfWar>();
        //rightControls = GameHandler.gameHandler.rightPlayer.GetComponent<PlayerControlsTugOfWar>();
    }

    public IEnumerator drinks()
    {
        while (countdown.started)
        {
            Debug.Log(ropePos);
            if (ropePos > 120)
            {
                leftDrinks.inDanger();
                GameHandler.gameHandler.leftPlayer.drinks += 1;
                GameHandler.gameHandler.rightPlayer.drinks++;
            }
            else if (ropePos < -120)
            {
                rightDrinks.inDanger();
                GameHandler.gameHandler.rightPlayer.drinks += 1;
                GameHandler.gameHandler.leftPlayer.drinks++;
            }
            yield return new WaitForSeconds(1.5f);
        }
    }

    public void someonePulled(char side)
    {
        if (countdown.started)
        {
            if (side == 'l')
            {
                leftPulls++;
                if(leftPulls % 5 == 0)
                {
                    rightDrinks.gettingPulled();
                    GameHandler.gameHandler.rightPlayer.drinks+=2;
                }
                ropePos -= 10;
                if (ropePos > 120)
                {
                    ropePos -= 5;
                }
            }
            else
            {
                rightPulls++;
                if (rightPulls % 5 == 0)
                {
                    leftDrinks.gettingPulled();
                    GameHandler.gameHandler.leftPlayer.drinks+=2;
                }
                ropePos += 10;
                if (ropePos < -120)
                {
                    ropePos += 5;
                }
            }
        }
    }

    IEnumerator minigameEnd()
    {
        yield return new WaitForSeconds(2.5f);
        GameHandler.gameHandler.minigameEnd();
    }

    // Update is called once per frame
    void Update()
    {
        rope.transform.localPosition = Vector3.Lerp(rope.transform.localPosition, new Vector2(ropePos, rope.transform.localPosition.y), 0.1f);
        if (ropePos > 250)
        {
            if (!winnerDeclared)
            {
                countdown.started = false;
                gameObject.GetComponent<Text>().text = GameHandler.gameHandler.rightPlayer.playerName + " won the Tug of War!";
                leftDrinks.lostTugOfWar();
                GameHandler.gameHandler.leftPlayer.drinks += 5;
                leftImage.sprite = lost;
                rightImage.sprite = victory;
                winnerDeclared = true;
                StartCoroutine(minigameEnd());
            }
        }
        else if (ropePos < -250)
        {
            if (!winnerDeclared)
            {
                countdown.started = false;
                gameObject.GetComponent<Text>().text = GameHandler.gameHandler.leftPlayer.playerName + " won the Tug of War!";
                rightDrinks.lostTugOfWar();
                GameHandler.gameHandler.rightPlayer.drinks += 5;
                rightImage.sprite = lost;
                leftImage.sprite = victory;
                winnerDeclared = true;
                StartCoroutine(minigameEnd());
            }
        }
        else if (ropePos < 120 && ropePos > -120)
        {
            leftImage.sprite = pulling;
            rightImage.sprite = pulling;
        }
        else if (ropePos > 120)
        {
            leftImage.sprite = desperate;
            rightImage.sprite = pulling;
        }
        else if (ropePos < -120)
        {
            leftImage.sprite = pulling;
            rightImage.sprite = desperate;
        }

    }

}
