using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlTicTacToe : MonoBehaviour
{
    public TicTacToeBoard board;
    public TicTacToeBoard.Turn sidedness;
    
    // Start is called before the first frame update
    void Start()
    {
        board = FindObjectOfType<TicTacToeBoard>();
        if (gameObject.GetComponent<Player>() == GameHandler.gameHandler.leftPlayer)
        {
            sidedness = TicTacToeBoard.Turn.left;
        }
        else
        {
            sidedness = TicTacToeBoard.Turn.right;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnConfirm()
    {
        board.confirm(sidedness);
        Debug.Log("confirming");
    }

    public void OnLeft()
    {
        board.left(sidedness);
        Debug.Log("left");
    }

    public void OnRight()
    {
        board.right(sidedness);
    }

    public void OnUp()
    {
        board.up(sidedness);
    }

    public void OnDown()
    {
        board.down(sidedness);
    }
}
