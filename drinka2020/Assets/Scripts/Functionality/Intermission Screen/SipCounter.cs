using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SipCounter : MonoBehaviour
{
    public Player player;
    [SerializeField] public int playerNumber;
    public PlayerControlsIntermission controls;
    public IntermissionCountdown countdown;
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
        controls = player.GetComponent<PlayerControlsIntermission>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = player.drinks.ToString();
    }

    public void OnDraw()
    {
        if (countdown.started)
        {
            player.drinks--;
        }
    }
}
