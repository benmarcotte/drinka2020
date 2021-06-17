using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.InputSystem;
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
    public bool timingActive = false;
    public bool countdownStarted = false;
    public bool rightFailed = false;
    public Text countdown;
    public PlayerControlsWar leftControls;
    public PlayerControlsWar rightControls;
    public PlayerInputManager playerInputManager;
    public static WarHandler warHandler;

    // Start is called before the first frame update
    void Awake()
    {
        warHandler = gameObject.GetComponent<WarHandler>();

    }

    private void Start()
    {
        leftControls = GameHandler.gameHandler.leftPlayer.GetComponent<PlayerControlsWar>();
        rightControls = GameHandler.gameHandler.rightPlayer.GetComponent<PlayerControlsWar>();
        playerInputManager = FindObjectOfType<PlayerInputManager>();
        //playerInputManager.GetComponent<PlayerInputManager>().playerPrefab.GetComponent<PlayerInput>().actions = Resources.Load<InputActionAsset>("Input Settings/War");
        scoreLimit = UnityEngine.Random.Range(2, 5) * 2;
        GetComponent<Text>().text = "Draw on Go!\nFirst to " + scoreLimit + "!";
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
            leftControls.fumbled = false;
            leftControls.succeeded = false;
            rightControls.fumbled = false;
            rightControls.succeeded = false;
            if (wonLeft.cards.Count >= scoreLimit)
            {
                gameObject.GetComponent<Text>().text = GameHandler.gameHandler.leftPlayer.playerName + " wins the War!";
                GameHandler.gameHandler.rightPlayer.drinks += 5;
                rightDrinks.lostWar();
                yield return new WaitForSeconds(2f);
                GameHandler.gameHandler.leftPlayer.score++;
                GameHandler.gameHandler.minigameEnd();
                break;
            }
            else if (wonRight.cards.Count >= scoreLimit)
            {
                gameObject.GetComponent<Text>().text = GameHandler.gameHandler.rightPlayer.playerName + " wins the War!";
                GameHandler.gameHandler.leftPlayer.drinks += 5;
                leftDrinks.lostWar();
                yield return new WaitForSeconds(2f);
                GameHandler.gameHandler.rightPlayer.score++;
                GameHandler.gameHandler.minigameEnd();
                break;
            }

            //Countdown Handling
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.5f, 2f));
            float interval = UnityEngine.Random.Range(0.15f, 0.5f);
            countdownStarted = true;
            countdown.text = "3";
            yield return new WaitForSeconds(interval);
            countdown.text = "2";
            yield return new WaitForSeconds(interval);
            countdown.text = "1";
            yield return new WaitForSeconds(interval - 0.1f);
            timingActive = true;
            yield return new WaitForSeconds(0.1f);
            countdown.text = "Go!";
            yield return new WaitForSeconds(0.1f);
            timingActive = false;
            yield return new WaitForSeconds(0.5f);
            countdown.text = "";
            countdownStarted = false;

            
            //Turn Resolving
            //if (!rightControls.fumbled && rightControls.succeeded)
            //{
            //    right.topCard.sendToStack(rightInPlay);
            //}
            //if(!leftControls.fumbled && leftControls.succeeded)
            //{
            //    left.topCard.sendToStack(leftInPlay);
            //}
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            

            try
            {
                rightInPlay.topCard.reveal();
                Debug.Log("Right card exists and revealed");
                if (rightInPlay.topCard.value == 14)
                {
                    rightDrinks.drewJoker();
                    GameHandler.gameHandler.rightPlayer.drinks += 5;
                }
            }
            catch //right did not draw card
            {
                Debug.Log("Right failed");
                if (!rightControls.fumbled)
                {
                    rightDrinks.didNothing();
                }
                if (leftControls.succeeded && !leftControls.fumbled)
                {
                    while (warRight.cards.Count > 0)
                    {
                        warRight.topCard.sendToStack(wonLeft);
                        diff++;
                    }
                    while (warLeft.cards.Count > 0)
                    {
                        warLeft.topCard.sendToStack(wonLeft);
                        diff++;
                    }
                    if(leftInPlay.topCard.value == 14)
                    {
                        leftDrinks.drewJoker();
                        GameHandler.gameHandler.leftPlayer.drinks += 5;
                    }
                    leftInPlay.topCard.sendToStack(wonLeft);
                    if (atWar)
                    {
                        rightDrinks.lostWar(diff);
                        GameHandler.gameHandler.rightPlayer.drinks += diff;
                        atWar = false;
                        diff = 0;
                    }
                    rightDrinks.lost();
                    GameHandler.gameHandler.rightPlayer.drinks += 2;
                }
                else
                {
                    rightDrinks.bothSuck();
                    GameHandler.gameHandler.rightPlayer.drinks += 3;
                }
            }
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            try
            {
                leftInPlay.topCard.reveal();
                Debug.Log("Left card exists and revealed");
                if (leftInPlay.topCard.value == 14)
                {
                    leftDrinks.drewJoker();
                    GameHandler.gameHandler.leftPlayer.drinks += 5;
                }
            }
            catch //either player did not draw card
            {
                if(!leftControls.succeeded)
                {
                    Debug.Log("Left failed");
                    if (!leftControls.fumbled)
                    {
                        leftDrinks.didNothing();
                    }
                    if (rightControls.succeeded && !rightControls.fumbled)
                    {
                        while (warRight.cards.Count > 0)
                        {
                            warRight.topCard.sendToStack(wonRight);
                            diff++;
                        }
                        while (warLeft.cards.Count > 0)
                        {
                            warLeft.topCard.sendToStack(wonRight);
                            diff++;
                        }
                        rightInPlay.topCard.sendToStack(wonRight);
                        if (atWar)
                        {
                            leftDrinks.lostWar(diff);
                            GameHandler.gameHandler.leftPlayer.drinks += diff;
                            atWar = false;
                            diff = 0;
                        }
                        leftDrinks.lost();
                        GameHandler.gameHandler.leftPlayer.drinks += 2;
                    }
                    else
                    {
                        leftDrinks.bothSuck();
                        GameHandler.gameHandler.leftPlayer.drinks += 3;
                    }
                }
                else
                {
                    Debug.Log("Left did not fail but is empty because right failed");
                }
            }

            yield return new WaitForSeconds(0.4f);
            if ((!rightControls.fumbled && rightControls.succeeded && !leftControls.fumbled && leftControls.succeeded))
            {
                //Debug.Log("Right fumbled?" + rightControls.fumbled);
                //Debug.Log("right succeeded?" + rightControls.succeeded);
                //Debug.Log("left fumbled?" + leftControls.fumbled);
                //Debug.Log("left succeeded?" + leftControls.succeeded);
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
                        GameHandler.gameHandler.leftPlayer.drinks += 2;
                        atWar = false;
                        diff = 0;
                    }
                    else
                    {
                        leftDrinks.lost();
                        GameHandler.gameHandler.leftPlayer.drinks += 2;
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
                        GameHandler.gameHandler.rightPlayer.drinks += 2;
                        atWar = false;
                        diff = 0;
                    }
                    else
                    {
                        rightDrinks.lost();
                        GameHandler.gameHandler.rightPlayer.drinks += 2;
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
    }

    public void sendCard(Player player)
    {
        if (player == GameHandler.gameHandler.leftPlayer)
        {
            left.topCard.reveal();
            left.topCard.sendToStack(leftInPlay);
        }
        else if (player == GameHandler.gameHandler.rightPlayer)
        {
            right.topCard.reveal();
            right.topCard.sendToStack(rightInPlay);
        }
        else
        {
            Debug.Log("What player is sending a card?");
        }
    }

    //IEnumerator handleCountdown()
    //{
    //    yield return new WaitForSeconds(UnityEngine.Random.Range(1.5f, 3f));
    //    float interval = UnityEngine.Random.Range(0.3f, 1f);
    //    countdownStarted = true;
    //    countdown.text = "3";
    //    yield return new WaitForSeconds(interval);
    //    countdown.text = "2";
    //    yield return new WaitForSeconds(interval);
    //    countdown.text = "1";
    //    yield return new WaitForSeconds(interval - 0.1f);
    //    timingActive = true;
    //    yield return new WaitForSeconds(0.1f);
    //    countdown.text = "Go!";
    //    yield return new WaitForSeconds(0.1f);
    //    timingActive = false;
    //    yield return new WaitForSeconds(0.5f);
    //    countdown.text = "";
    //    countdownStarted = false;
    //}

    //IEnumerator resolveTurn()
    //{
    //    try
    //    {
    //        rightInPlay.topCard.reveal();
    //        if (rightInPlay.topCard.value == 14)
    //        {
    //            rightDrinks.drewJoker();
    //            GameHandler.gameHandler.rightPlayer.drinks += 5;
    //        }
    //    }
    //    catch
    //    {
    //        if (!rightControls.fumbled)
    //        {
    //            rightDrinks.didNothing();
    //        }
    //        GameHandler.gameHandler.rightPlayer.drinks++;
    //    }

    //    try
    //    {
    //        Debug.Log("trying");
    //        leftInPlay.topCard.reveal();
    //        Debug.Log("failed");
    //        if (leftInPlay.topCard.value == 14)
    //        {
    //            leftDrinks.drewJoker();
    //            GameHandler.gameHandler.leftPlayer.drinks += 5;
    //        }
    //    }
    //    catch
    //    {
    //        if (!leftControls.fumbled)
    //        {
    //            leftDrinks.didNothing();
    //        }
    //        GameHandler.gameHandler.leftPlayer.drinks++;
    //    }

        

    //    if(!rightControls.fumbled && rightControls.succeeded && !leftControls.fumbled && leftControls.succeeded)
    //    {
    //        if (rightInPlay.topCard.value > leftInPlay.topCard.value)
    //        {
    //            while (warRight.cards.Count > 0)
    //            {
    //                warRight.topCard.sendToStack(wonRight);
    //                yield return new WaitForEndOfFrame();
    //                diff++;
    //            }
    //            while (warLeft.cards.Count > 0)
    //            {
    //                warLeft.topCard.sendToStack(wonRight);
    //                yield return new WaitForEndOfFrame();
    //                diff++;
    //            }
    //            leftInPlay.topCard.sendToStack(wonRight);
    //            rightInPlay.topCard.sendToStack(wonRight);
    //            if (atWar)
    //            {
    //                leftDrinks.lostWar(diff);
    //                leftDrinks.lost();
    //                GameHandler.gameHandler.leftPlayer.drinks += diff;
    //                GameHandler.gameHandler.leftPlayer.drinks++;
    //                atWar = false;
    //                diff = 0;
    //            }
    //            else
    //            {
    //                leftDrinks.lost();
    //                GameHandler.gameHandler.leftPlayer.drinks++;
    //            }
    //        }
    //        else if (leftInPlay.topCard.value > rightInPlay.topCard.value)
    //        {
    //            while (warRight.cards.Count > 0)
    //            {
    //                warRight.topCard.sendToStack(wonLeft);
    //                yield return new WaitForEndOfFrame();
    //                diff++;
    //            }
    //            while (warLeft.cards.Count > 0)
    //            {
    //                warLeft.topCard.sendToStack(wonLeft);
    //                yield return new WaitForEndOfFrame();
    //                diff++;
    //            }
    //            leftInPlay.topCard.sendToStack(wonLeft);
    //            rightInPlay.topCard.sendToStack(wonLeft);
    //            if (atWar)
    //            {
    //                rightDrinks.lostWar(diff);
    //                rightDrinks.lost();
    //                GameHandler.gameHandler.rightPlayer.drinks += diff;
    //                GameHandler.gameHandler.rightPlayer.drinks++;
    //                atWar = false;
    //                diff = 0;
    //            }
    //            else
    //            {
    //                rightDrinks.lost();
    //                GameHandler.gameHandler.rightPlayer.drinks++;
    //            }
    //        }
    //        else
    //        {
    //            rightInPlay.topCard.sendToStack(warRight);
    //            leftInPlay.topCard.sendToStack(warLeft);
    //            atWar = true;
    //        }
    //    }
    //}

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
