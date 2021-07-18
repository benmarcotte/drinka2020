using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeHandler : MonoBehaviour
{
    public Text text;
    public Button button;
    public Text buttonText;
    public TicTacToeDrinks leftDrinks;
    public TicTacToeDrinks rightDrinks;
    public Player leftPlayer;
    public Player rightPlayer;
    public static TicTacToeHandler ticTacToeHandler;
    public bool winnerDeclared = false;
    public Sprite lost;
    public Sprite victory;
    public long framecount;
    public Stopwatch timer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch();
        leftPlayer = GameHandler.gameHandler.leftPlayer;
        rightPlayer = GameHandler.gameHandler.rightPlayer;
        ticTacToeHandler = gameObject.GetComponent<TicTacToeHandler>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
