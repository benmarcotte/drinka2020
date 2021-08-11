using System;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeBoard : MonoBehaviour
{
    [SerializeField] public Component[,] buttons = new Component[3,3];
    public Player leftPlayer;
    public Player rightPlayer;
    [SerializeField] public CountdownTicTacToe timer;
    public enum Turn { left, right };
    public Turn currentTurn;
    public Player currentPlayer;
    public Component currentButton;
    public (int x, int y) position;
    public Component[,] claimed = new Component[3, 3];
    [SerializeField] public char[,] chars = new char[3,3];
    public ColorBlock restingButton;
    [SerializeField] public Image line;
    public Quaternion zero = new Quaternion(0, 0, 0.7071068f, 0.7071068f);
    public Quaternion FFdeg = new Quaternion(0.01451165f, -0.006010921f, 0.3826362f, 0.9237656f);
    public Quaternion OTFdeg = new Quaternion(0.006010924f, -0.01451165f, 0.9237656f, 0.3826362f);
    private bool winnerDeclared = false;

    // Start is called before the first frame update
    void Start()
    {
        line.enabled = false;
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
        if(UnityEngine.Random.Range(0, 2) == 1)
        {
            currentTurn = Turn.left;
            currentPlayer = GameHandler.gameHandler.leftPlayer;
        }
        else
        {
            currentTurn = Turn.right;
            currentPlayer = GameHandler.gameHandler.rightPlayer;
        }
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

    public void changeTurn(bool timeout = false)
    {
        if (currentTurn == Turn.left)
        {
            currentButton = buttons[0, 2];
            position = (0, 2);
            currentPlayer = GameHandler.gameHandler.rightPlayer;
            if (timeout)
            {
                TicTacToeHandler.ticTacToeHandler.leftDrinks.timeout();
                leftPlayer.drinks += 2;
            }
            currentTurn = Turn.right;
            timer.resetTimer();
        }
        else
        {
            currentButton = buttons[0, 0];
            position = (0, 0);
            currentPlayer = GameHandler.gameHandler.leftPlayer;
            if (timeout)
            {
                TicTacToeHandler.ticTacToeHandler.rightDrinks.timeout();
                rightPlayer.drinks += 2;
            }
            currentTurn = Turn.left;
            timer.resetTimer();
        }
    }

    public void confirm(Turn side)
    {
        if (side == currentTurn && timer.started)
        {
            if (!isClaimed(currentButton))
            {
                if(side == Turn.left)
                {
                    currentButton.GetComponentInChildren<Text>().text = "X";
                    currentButton.GetComponentInChildren<Text>().color = GameHandler.gameHandler.leftPlayer.color;
                    chars[position.x, position.y] = 'x';
                    TicTacToeHandler.ticTacToeHandler.leftDrinks.tic();
                    leftPlayer.drinks++;
                    checkWinner(Turn.left);
                    changeTurn();
                }
                else
                {
                    currentButton.GetComponentInChildren<Text>().text = "O";
                    currentButton.GetComponentInChildren<Text>().color = GameHandler.gameHandler.rightPlayer.color;
                    chars[position.x, position.y] = 'o';
                    TicTacToeHandler.ticTacToeHandler.rightDrinks.tic();
                    rightPlayer.drinks++;
                    checkWinner(Turn.right);
                    changeTurn();
                }
            }
        }
    }

    public void checkWinner(Turn c)
    {
        if(chars[0,0] == chars[0,1] && chars[0,1] == chars[0,2] && chars[0,0] != '0')
        {
            line.gameObject.transform.rotation = new Quaternion(0, 0, 0.7071068f, 0.7071068f);
            line.gameObject.transform.localPosition = new Vector3(0, 130f, 0);
            declareWinner(c);
        }
        else if (chars[1, 0] == chars[1, 1] && chars[1, 1] == chars[1, 2] && chars[1, 0] != '0')
        {
            line.gameObject.transform.rotation = new Quaternion(0, 0, 0.7071068f, 0.7071068f);
            line.gameObject.transform.localPosition = Vector3.zero;
            declareWinner(c);
        }
        else if (chars[2, 0] == chars[2, 1] && chars[2, 1] == chars[2, 2] && chars[2, 0] != '0')
        {
            line.gameObject.transform.rotation = new Quaternion(0, 0, 0.7071068f, 0.7071068f);
            line.gameObject.transform.localPosition = new Vector3(0, -130f, 0);
            declareWinner(c);
        }
        else if (chars[0, 0] == chars[1, 0] && chars[1, 0] == chars[2, 0] && chars[0, 0] != '0')
        {
            line.gameObject.transform.rotation = new Quaternion(0, 0, 0, 1);
            line.gameObject.transform.localPosition = new Vector3(-135f, 0, 0);
            declareWinner(c);
        }
        else if (chars[0, 1] == chars[1, 1] && chars[1, 1] == chars[2, 1] && chars[0, 1] != '0')
        {
            line.gameObject.transform.rotation = new Quaternion(0, 0, 0, 1);
            line.gameObject.transform.localPosition = Vector3.zero;
            Debug.Log("center vert win");
            declareWinner(c);
        }
        else if (chars[0, 2] == chars[1, 2] && chars[1, 2] == chars[2, 2] && chars[0, 2] != '0')
        {
            line.gameObject.transform.rotation = new Quaternion(0, 0, 0, 1);
            line.gameObject.transform.localPosition = new Vector3(135f, 0, 0);
            declareWinner(c);
        }
        else if (chars[0, 0] == chars[1, 1] && chars[1, 1] == chars[2, 2] && chars[0, 0] != '0')
        {
            line.gameObject.transform.rotation = FFdeg;
            line.gameObject.transform.localPosition = Vector3.zero;
            declareWinner(c);
        }
        else if (chars[0, 2] == chars[1, 1] && chars[1, 1] == chars[2, 0] && chars[2, 0] != '0')
        {
            line.gameObject.transform.rotation = OTFdeg;
            line.gameObject.transform.localPosition = Vector3.zero;
            declareWinner(c);
        } 
        else
        {
            bool nozeroes = true;
            foreach(char d in chars)
            {
                if(d == '0')
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
        TicTacToeHandler.ticTacToeHandler.leftDrinks.draw();
        TicTacToeHandler.ticTacToeHandler.rightDrinks.draw();
        leftPlayer.drinks += 5;
        rightPlayer.drinks += 5;
        timer.Stop();
        timer.enabled = false;
        Invoke("minigameEnd", 3f);
        winnerDeclared = true;
    }

    public void declareWinner(Turn c)
    {
        if(c == Turn.left)
        {
            line.color = leftPlayer.color;
            line.enabled = true;
            rightPlayer.drinks += 5;
            TicTacToeHandler.ticTacToeHandler.rightDrinks.lost();
        }
        else
        {
            line.color = rightPlayer.color;
            line.enabled = true;
            leftPlayer.drinks += 5;
            TicTacToeHandler.ticTacToeHandler.leftDrinks.lost();
        }
        timer.Stop();
        winnerDeclared = true;
        timer.enabled = false;
        Invoke("minigameEnd", 3f);
    }

    void minigameEnd()
    {
        GameHandler.gameHandler.minigameEnd();
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
            if (button.Equals(currentButton) && timer.started && !winnerDeclared)
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
