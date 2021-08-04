using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    Player player;
    [SerializeField] string side;
    bool chosen = false;
    enum Options { rock, paper, scissors }
    Options choice; 
    
    // Start is called before the first frame update
    void Start()
    {
        if(side == "L")
        {
            player = GameHandler.gameHandler.leftPlayer;
        }
        else
        {
            player = GameHandler.gameHandler.rightPlayer;
        }
    }

    public void Rock()
    {
        choice = Options.rock;
        chosen = true;
    }

    public void Paper()
    {
        choice = Options.paper;
        chosen = true;
    }

    public void Scissors()
    {
        choice = Options.scissors;
        chosen = true;
    }

    // Update is called once per frame

}
