using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPSHandler : MonoBehaviour
{
    [SerializeField] Hand left;
    [SerializeField] Hand right;
    [SerializeField] Text status;
    [SerializeField] Sprite rock;
    [SerializeField] Sprite paper;
    [SerializeField] Sprite scissors;
    bool leftPicked = false;
    bool rightPicked = false;
    bool resolved = false;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void resolveGame()
    {
          //is a draw
        if ((left.Rock() && right.Rock()) || (left.Paper() && right.Paper()) || (left.Scissors() && right.Scissors())) {
            status.GetComponent<Text>().text= "Draw! Both gets drinks";
        }

        //left wins
        if ( (left.Rock() && right.Scissors()) || (left.Scissors() && right.Paper()) || (left.Paper() && right.Rock())) {
            status.GetComponent<Text>().text= "Left Wins!";
        }

        //right wins
        else {
            status.GetComponent<Text>().text= "Right Wins!";

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(leftPicked && rightPicked && !resolved)
        {
            resolveGame();
            resolved = true;
        }
    }
}
