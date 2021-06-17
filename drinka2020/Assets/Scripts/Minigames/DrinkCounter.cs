using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkCounter : MonoBehaviour
{
    public Player player;
    public int number;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (number == 0)
        {
            player = GameHandler.gameHandler.leftPlayer;
        }
        else
        {
            player = GameHandler.gameHandler.rightPlayer;
        }
        text = GetComponent<Text>();
        text.color = player.color;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player.drinks.ToString();
    }

}
