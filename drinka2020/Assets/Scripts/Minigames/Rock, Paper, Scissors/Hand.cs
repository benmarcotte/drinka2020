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
    
    [SerializeField] Sprite rock;
    [SerializeField] Sprite paper;
    [SerializeField] Sprite scissors;

    [SerializeField] Sprite left_img;
    [SerializeField] Sprite right_img;
    
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
    
    //methods to compare in the rpshandler class
    public string choice_left() {

        if(choice==Options.rock)
        {
            //left_img.GetComponent<Image>().sprite=rock;
            return "rock";
        }

        if(choice == Options.paper) 
        {
            //left_img.GetComponent<Image>().sprite=paper;
            return "paper";
        }

        else 
        {
            //left_img.GetComponent<Image>().sprite=scissors;
            return "scissors";
        }

    }

     public string choice_right() {

        if(choice==Options.rock)
        {
            //right_img.GetComponent<Image>().sprite=rock;
            return "rock";
        }

        if(choice == Options.paper) 
        {
            //right_img.GetComponent<Image>().sprite=paper;
            return "paper";
        }

        else {
            //right_img.GetComponent<Image>().sprite=scissors;
            return "scissors";
        }
     }

    // Update is called once per frame

}
