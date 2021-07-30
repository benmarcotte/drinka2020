using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

  enum options { Rock=1, Paper=2, Scissors=3}

  private int player1_choice = -1;
  private int player2_choice = -1;

  private bool player1_turn = true;
  private bool player2_turn= true;

  public GameObject winner_text;

  //variables for the images ??
  public Sprite paper_img, rock_img, scissor_img;

  //player choose images??
  public GameObject p1_choose_img;
  public GameObject p2_choose_img;

  void Update () {

    if (player1_turn && player1_choice== -1) return;

    else {
      P2_Choose();
      check_winner();
      player1_choice= -1;
      player2_choice= -1;
      player1_turn= true;
      player2_turn= true;

    }
  }

//deciding the winner
  void check_winner () {

    //if it's a draw 
    if (player1_choice == player2_choice) {

      winner_text.GetComponent<Text>().text= "It's a DRAW.";

      // option to go again ?

    }

    //player1 wins

    else if ((player1_choice == (int)options.Paper && player2_choice == (int)options.Rock) || 
    (player1_choice == (int)options.Rock && player2_choice == (int)options.Scissors) || 
    (player1_choice == (int)options.Scissors && player2_choice == (int)options.Paper)) {

    winner_text.GetComponent<Text>().text= "Player 1 wins!";
    }

    //Player2 wins

    else {
      winner_text.GetComponent<Text>().text= "Player 2 wins!";
    }



  }

//turn for player 1
  public void P1_Choose(int choose1) {
    player1_choice=choose1;
    player1_turn=false;

    //to show the chosen images
    if (player1_choice == 1) {
      p1_choose_img.GetComponent<Image>().sprite= rock_img ; //ROCK
    }

    else if (player1_choice == 2) {
      p1_choose_img.GetComponent<Image>().sprite= paper_img ; //PAPER
    }

    else {
      p1_choose_img.GetComponent<Image>().sprite= scissor_img; //SCISSORS
    }
  }

//turn for player 2 
  public void P2_Choose(int choose2) {
    player2_choice= choose2;
    player2_turn= false;

//to show the chosen images
    if (player2_choice == 1) {
      p2_choose_img.GetComponent<Image>().sprite= rock_img ; //ROCK
    }

    else if (player2_choice == 2) {
      p2_choose_img.GetComponent<Image>().sprite= paper_img ; //PAPER
    }

    else {
      p2_choose_img.GetComponent<Image>().sprite= scissor_img; //SCISSORS
    }



  }

}
