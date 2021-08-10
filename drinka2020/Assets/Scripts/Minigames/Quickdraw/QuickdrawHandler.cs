using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuickdrawHandler : MonoBehaviour, IHandler
{
    public TextMeshProUGUI drawText;
    public bool drawn = false;
    public bool started = false;
    public bool someoneShot = false;
    public bool tricked = false;
    public static QuickdrawHandler quickdrawHandler;
    public Player leftPlayer;
    public Player rightPlayer;
    public Text status;
    public QuickdrawDrinks leftDrinks;
    public QuickdrawDrinks rightDrinks;
    public Stopwatch timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch();
        leftPlayer = GameHandler.gameHandler.leftPlayer;
        rightPlayer = GameHandler.gameHandler.rightPlayer;
        quickdrawHandler = gameObject.GetComponent<QuickdrawHandler>();
        StartCoroutine(draw());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gotTricked(Player player)
    {
        if(player == GameHandler.gameHandler.leftPlayer)
        {
            GameHandler.gameHandler.leftPlayer.drinks += 5;
            leftDrinks.gotTricked();
        }
        else
        {
            GameHandler.gameHandler.rightPlayer.drinks += 5;
            rightDrinks.gotTricked();
        }
    }

    public void wonDraw(Player player)
    {
        if(player == GameHandler.gameHandler.leftPlayer)
        {
            rightDrinks.lost();
            rightDrinks.gotShot();
            GameHandler.gameHandler.rightPlayer.drinks += 10;
        }
        else
        {
            leftDrinks.lost();
            leftDrinks.gotShot();
            GameHandler.gameHandler.leftPlayer.drinks += 10;
        }
        status.text = player.playerName + " won the duel!";
        StartCoroutine(endDuel());
    }

    public void lostByEarlyShot(Player player)
    {
        if(player == GameHandler.gameHandler.leftPlayer)
        {
            leftDrinks.shotEarly();
            leftDrinks.lost();
            rightDrinks.gotShot();
            GameHandler.gameHandler.leftPlayer.drinks += 20;
            GameHandler.gameHandler.rightPlayer.drinks += 5;
            GameHandler.gameHandler.rightPlayer.score++;
        }
        else
        {
            rightDrinks.shotEarly();
            rightDrinks.lost();
            leftDrinks.gotShot();
            GameHandler.gameHandler.rightPlayer.drinks += 20;
            GameHandler.gameHandler.leftPlayer.drinks += 5;
            GameHandler.gameHandler.leftPlayer.score++;
        }
        status.text = player.playerName + " shot early!";
        StartCoroutine(endDuel());
    }

    IEnumerator endDuel()
    {
        yield return new WaitForSeconds(3f);
        GameHandler.gameHandler.minigameEnd();
    }

    public IEnumerator draw()
    {
        yield return new WaitForSeconds(3f);
        drawText.text = "Ready...";
        started = true;
        yield return new WaitForSeconds(1f);
        drawText.text = "";
        yield return new WaitForSeconds(Random.Range(1f, 4f));
        drawText.text = "Steady.";
        int dots = Random.Range(1, 8);
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < dots; i++)
        {
            drawText.text += ".";
            if (i == dots - 1)
            {
                if(Random.Range(0, 2) == 1)
                {
                    yield return new WaitForSeconds(Random.Range(0.8f, 2f));
                }
                else
                {
                    yield return new WaitForSeconds(0.5f);
                }
            }
            else
            {
                yield return new WaitForSeconds(0.5f);
            }
        }
        drawText.text = "";
        yield return new WaitForSeconds(Random.Range(3f, 8f));
        if (Random.Range(0f, 1f) < 0.33f)
        {
            drawText.text = "Don't!";
            tricked = true;
            yield return new WaitForSeconds(0.75f);
            drawText.text = "";
            tricked = false;
            if(Random.Range(0f, 1f) < 0.1f)
            {
                drawText.text = "Don't!";
                tricked = true;
                yield return new WaitForSeconds(0.75f);
                tricked = false;
                
            }
            yield return new WaitForSeconds(Random.Range(0.5f, 4f));
        }
        timer.Start();
        drawn = true;
        drawText.fontStyle = FontStyles.Bold | FontStyles.Italic;
        drawText.text = "Draw!!!";
    }
}
