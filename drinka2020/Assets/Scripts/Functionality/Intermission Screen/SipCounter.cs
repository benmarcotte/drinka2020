using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SipCounter : MonoBehaviour
{
    public Player player;
    [SerializeField] public int playerNumber;
    // Start is called before the first frame update
    void Start()
    {
        if(playerNumber == 0)
        {
            player = GameHandler.gameHandler.leftPlayer;
        } 
        else
        {
            player = GameHandler.gameHandler.rightPlayer;
        }
        GetComponent<Text>().color = player.color;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = player.drinks.ToString();
    }

    public void OnSip()
    {
        player.drinks--;
    }
}
