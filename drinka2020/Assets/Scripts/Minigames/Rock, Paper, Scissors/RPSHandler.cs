using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPSHandler : MonoBehaviour
{
    [SerializeField] Hand left;
    [SerializeField] Hand right;
    [SerializeField] Text status;
   
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
        if (left.choice_left() == right.choice_right()) {
            status.GetComponent<Text>().text= "Draw!";
        }

        //left wins
        if(((left.choice_left()=="rock") && (right.choice_right()=="scissors"))  ||
            ((left.choice_left()=="scissors") && (right.choice_right()=="paper")) ||
            ((left.choice_left()=="paper") && (right.choice_right()=="rock")))
        {
             status.GetComponent<Text>().text= "Left wins!";
        }

        //right wins
        else {
            status.GetComponent<Text>().text= "Right wins!";
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
