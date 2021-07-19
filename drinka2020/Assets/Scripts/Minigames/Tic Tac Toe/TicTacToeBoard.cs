using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeBoard : MonoBehaviour
{
    [SerializeField] public Component[,] buttons = new Component[3,3];
    public Player leftPlayer;
    public Player rightPlayer;
    public enum Turn { left, right };
    public Turn currentTurn;
    public Player currentPlayer;
    public Component currentButton;
    public (int x, int y) position;
    public Component[,] claimed = new Component[3, 3];
    [SerializeField] public char[,] chars = new char[3,3];
    public ColorBlock restingButton;

    // Start is called before the first frame update
    void Start()
    {
        Component[] temp = GetComponentsInChildren(typeof(Button));
        claimed[0, 0] = buttons[0, 0] = temp[0];
        claimed[0, 1] = buttons[0, 1] = temp[1];
        claimed[0, 2] = buttons[0, 2] = temp[2];
        claimed[1, 0] = buttons[1, 0] = temp[3];
        claimed[1, 1] = buttons[1, 1] = temp[4];
        claimed[1, 2] = buttons[1, 2] = temp[5];
        claimed[2, 0] = buttons[2, 0] = temp[6];
        claimed[2, 1] = buttons[2, 1] = temp[7];
        claimed[2, 2] = buttons[2, 2] = temp[8];
        leftPlayer = GameHandler.gameHandler.leftPlayer;
        rightPlayer = GameHandler.gameHandler.rightPlayer;
        decideFirst();
        position = (0, 0);
        currentButton = buttons[0, 0];
        restingButton = ColorBlock.defaultColorBlock;
        restingButton.normalColor = new Color(0f, 0f, 0f, 0f);
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                chars[i, j] = '0';
            }
        }
    }

    public void decideFirst()
    {
        //placeholder for now
        currentTurn = Turn.left;
        currentPlayer = GameHandler.gameHandler.leftPlayer;
    }

    public bool isClaimed(Component button)
    {
        if(!(button
            .GetComponentInChildren<Text>()
            .text
            == "X" || 
            button
            .GetComponentInChildren<Text>(
                ).text
                == "O"))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void confirm(Turn side)
    {
        if (side == currentTurn)
        {
            if (!isClaimed(currentButton))
            {
                if(side == Turn.left)
                {
                    currentButton.GetComponentInChildren<Text>().text = "X";
                    currentButton.GetComponentInChildren<Text>().color = GameHandler.gameHandler.leftPlayer.color;
                    currentTurn = Turn.right;
                    currentPlayer = GameHandler.gameHandler.rightPlayer;
                    currentButton = buttons[0, 2];
                    chars[position.x, position.y] = 'x';
                    position = (0, 2);
                    checkWinner();
                }
                else
                {
                    currentButton.GetComponentInChildren<Text>().text = "O";
                    currentButton.GetComponentInChildren<Text>().color = GameHandler.gameHandler.rightPlayer.color;
                    currentTurn = Turn.left;
                    currentPlayer = GameHandler.gameHandler.leftPlayer;
                    currentButton = buttons[0, 0];
                    chars[position.x, position.y] = 'o';
                    position = (0, 0);
                    checkWinner();
                }
            }
        }
    }

    public void checkWinner()
    {
        if(chars[0,0] == chars[0,1] && chars[0,1] == chars[0,2] && chars[0,0] != '0')
        {
            declareWinner();
        }
        else if (chars[1, 0] == chars[1, 1] && chars[1, 1] == chars[1, 2] && chars[1, 0] != '0')
        {
            declareWinner();
        }
        else if (chars[2, 0] == chars[2, 1] && chars[2, 1] == chars[2, 2] && chars[2, 0] != '0')
        {
            declareWinner();
        }
        else if (chars[0, 0] == chars[1, 0] && chars[1, 0] == chars[2, 0] && chars[0, 0] != '0')
        {
            declareWinner();
        }
        else if (chars[1, 0] == chars[1, 1] && chars[1, 1] == chars[1, 2] && chars[1, 0] != '0')
        {
            declareWinner();
        }
        else if (chars[2, 0] == chars[2, 1] && chars[2, 1] == chars[2, 2] && chars[2, 0] != '0')
        {
            declareWinner();
        }
        else if (chars[0, 0] == chars[1, 1] && chars[1, 1] == chars[2, 2] && chars[0, 0] != '0')
        {
            declareWinner();
        }
        else if (chars[0, 2] == chars[1, 1] && chars[1, 1] == chars[2, 0] && chars[2, 0] != '0')
        {
            declareWinner();
        } 
        else
        {
            bool nozeroes = true;
            foreach(char c in chars)
            {
                if(c == '0')
                {
                    nozeroes = false;
                }
            }
            if (nozeroes)
            {
                declareDraw();
            }
        }
    }

    public void declareDraw()
    {
        foreach (Component button in buttons)
        {
            button.GetComponentInChildren<Text>().text = "F";
        }
    }

    public void declareWinner()
    {
        Debug.Log("Winner");
        foreach(Component button in buttons)
        {
            button.GetComponentInChildren<Text>().text = "W";
        }
    }

    public void up(Turn side)
    {
        if(side == currentTurn)
        {
            position = (position.x - 1, position.y);
            if(position.x == -1)
            {
                position.x = 0;
            }
            currentButton = buttons[position.x, position.y];

        }
    }

    public void down(Turn side)
    {
        if (side == currentTurn)
        {
            position = (position.x + 1, position.y);
            if (position.x == 3)
            {
                position.x = 2;
            }
            currentButton = buttons[position.x, position.y];

        }
    }

    public void left(Turn side)
    {
        if (side == currentTurn)
        {
            position = (position.x, position.y - 1);
            if (position.y == -1)
            {
                position.y = 0;
            }
            currentButton = buttons[position.x, position.y];

        }
    }

    public void right(Turn side)
    {
        if (side == currentTurn)
        {
            position = (position.x, position.y + 1);
            if (position.y == 3)
            {
                position.y = 2;
            }
            currentButton = buttons[position.x, position.y];

        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Component button in buttons)
        {
            if (button.Equals(currentButton))
            {
                ColorBlock colors = button.GetComponent<Button>().colors;
                colors.normalColor = new Color(currentPlayer.color.r, currentPlayer.color.g, currentPlayer.color.b, 0.8f);
                button.GetComponent<Button>().colors = colors;
            }
            else
            {
                button.GetComponent<Button>().colors = restingButton;
            }
        }
    }
}
