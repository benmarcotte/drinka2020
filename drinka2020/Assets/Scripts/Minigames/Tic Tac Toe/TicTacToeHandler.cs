using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeHandler : MonoBehaviour
{
    public Text text;
    [SerializeField] public TicTacToeDrinks leftDrinks;
    [SerializeField] public TicTacToeDrinks rightDrinks;
    [SerializeField] public Text leftCounter;
    [SerializeField] public Text rightCounter;
    public Player leftPlayer;
    public Player rightPlayer;
    public static TicTacToeHandler ticTacToeHandler;
    public bool winnerDeclared = false;
    
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        leftPlayer = GameHandler.gameHandler.leftPlayer;
        rightPlayer = GameHandler.gameHandler.rightPlayer;
        ticTacToeHandler = gameObject.GetComponent<TicTacToeHandler>();
        leftCounter.color = leftPlayer.color;
        rightCounter.color = rightPlayer.color;
    }

    // Update is called once per frame
    void Update()
    {
        leftCounter.text = leftPlayer.drinks.ToString();
        rightCounter.text = rightPlayer.drinks.ToString();
    }
}
