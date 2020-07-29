using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissors : Minigame
{
	enum Choice {Rock, Paper, Scissors};
	enum GameState {PreGame, InGame, PostGame};

	bool playerOneChose = false;
	bool playerTwoChose = false;

	Choice playerOneChoice;
	Choice playerTwoChoice;

	GameState gameState;

	public GameObject P1WinText, P2WinText, P1LoseText, P2LoseText;
	public GameObject canvas, scoreBoard;

    // Start is called before the first frame update
    void Awake()
    {
        gameName = "Rock, Paper, Scissors";
        gameState = GameState.PreGame;
    }

    void Start()
    {
    	canvas = GameObject.Find("Canvas");
    	scoreBoard = canvas.transform.GetChild(0).gameObject;

    	P1WinText = scoreBoard.transform.GetChild(0).transform.GetChild(0).gameObject;
    	P1LoseText = scoreBoard.transform.GetChild(0).transform.GetChild(1).gameObject;

    	P2WinText = scoreBoard.transform.GetChild(1).transform.GetChild(0).gameObject;
    	P2LoseText = scoreBoard.transform.GetChild(1).transform.GetChild(1).gameObject;

    	gameState = GameState.InGame;

    	P1LoseText.SetActive(false);
    	P1WinText.SetActive(false);
    	P2LoseText.SetActive(false);
    	P2WinText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    	//Gather Player inputs
        if (gameState == GameState.InGame)
        {
        	if (!playerOneChose && Input.GetKeyDown(KeyCode.A))
        	{
        		playerOneChose = true;
        		playerOneChoice = Choice.Rock;
        	}
        	if (!playerOneChose && Input.GetKeyDown(KeyCode.W))
        	{
        		playerOneChose = true;
        		playerOneChoice = Choice.Paper;
        	}
        	if (!playerOneChose && Input.GetKeyDown(KeyCode.D))
        	{
        		playerOneChose = true;
        		playerOneChoice = Choice.Scissors;
        	}

        	if (!playerTwoChose && Input.GetKeyDown(KeyCode.LeftArrow))
        	{
        		playerTwoChose = true;
        		playerTwoChoice = Choice.Rock;
        	}
        	if (!playerTwoChose && Input.GetKeyDown(KeyCode.UpArrow))
        	{
        		playerTwoChose = true;
        		playerTwoChoice = Choice.Paper;
        	}
        	if (!playerTwoChose && Input.GetKeyDown(KeyCode.RightArrow))
        	{
        		playerTwoChose = true;
        		playerTwoChoice = Choice.Scissors;
        	}
        }

        if (playerOneChose && playerTwoChose) {
        	gameState = GameState.PostGame;
        }

        if (gameState == GameState.PostGame) {
        	if (playerOneChoice == Choice.Rock) {
        		if (playerTwoChoice == playerOneChoice) {
        			SetScoreBoard(false, false);
        		}
        		else if (playerTwoChoice == Choice.Paper) {
        			SetScoreBoard(false, true);
        		}
        		else {
        			SetScoreBoard(true, false);
        		}
        	}
        	else if (playerOneChoice == Choice.Paper) {
        		if (playerTwoChoice == playerOneChoice) {
        			SetScoreBoard(false, false);
        		}
        		else if (playerTwoChoice == Choice.Scissors) {
        			SetScoreBoard(false, true);
        		}
        		else {
        			SetScoreBoard(true, false);
        		}
        	}
        	else if (playerOneChoice == Choice.Scissors) {
        		if (playerTwoChoice == playerOneChoice) {
        			SetScoreBoard(false, false);
        		}
        		else if (playerTwoChoice == Choice.Rock) {
        			SetScoreBoard(false, true);
        		}
        		else {
        			SetScoreBoard(true, false);
        		}
        	}
        }
 
        //TODO Add game logic, add drink style points

    }

    private void SetScoreBoard (bool p1, bool p2) {
    	P1LoseText.SetActive(!p1);
    	P1WinText.SetActive(p1);
    	P2LoseText.SetActive(!p2);
    	P2WinText.SetActive(p2);
    }
}
