using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkCounter : MonoBehaviour
{
    public Player player;
    public int number;
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
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = player.drinks.ToString();
    }
}
