using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    Player player;
    [SerializeField] string side;
    public bool chosen = false;
    public bool canChoose = false;
    public enum Options { rock, paper, scissors, none }
    public Options choice; 
    
    [SerializeField] Sprite rock;
    [SerializeField] Sprite paper;
    [SerializeField] Sprite scissors;
    [SerializeField] public Sprite none;

    [SerializeField] public Image img;

    
    // Start is called before the first frame update
    void Start()
    {
        img.sprite = none;
        choice = Options.none;
        if (side == "L")
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
        if (canChoose)
        {
            choice = Options.rock;
            img.sprite = rock;
            chosen = true;
        }
    }

    public void Paper()
    {
        if (canChoose)
        {
            choice = Options.paper;
            img.sprite = paper;
            chosen = true;
        }
    }

    public void Scissors()
    {
        if (canChoose)
        {
            choice = Options.scissors;
            img.sprite = scissors;
            chosen = true;
        }
    }
    
    //methods to compare in the rpshandler class
    //public string choice_left() {

    //    if(choice==Options.rock)
    //    {
    //        //left_img.GetComponent<Image>().sprite=rock;
    //        return "rock";
    //    }

    //    if(choice == Options.paper) 
    //    {
    //        //left_img.GetComponent<Image>().sprite=paper;
    //        return "paper";
    //    }

    //    else 
    //    {
    //        //left_img.GetComponent<Image>().sprite=scissors;
    //        return "scissors";
    //    }

    //}

    // public string choice_right() {

    //    if(choice==Options.rock)
    //    {
    //        //right_img.GetComponent<Image>().sprite=rock;
    //        return "rock";
    //    }

    //    if(choice == Options.paper) 
    //    {
    //        //right_img.GetComponent<Image>().sprite=paper;
    //        return "paper";
    //    }

    //    else {
    //        //right_img.GetComponent<Image>().sprite=scissors;
    //        return "scissors";
    //    }
    // }

    // Update is called once per frame

}
