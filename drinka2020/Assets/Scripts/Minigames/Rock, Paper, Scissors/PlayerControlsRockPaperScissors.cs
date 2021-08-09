using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsRockPaperScissors : MonoBehaviour
{
    Hand hand;
    // Start is called before the first frame update

    private void Start()
    {
        if(gameObject.GetComponent<Player>() == GameHandler.gameHandler.leftPlayer)
        {
            hand = FindObjectsOfType<Hand>()[1];
        }
        else
        {
            hand = FindObjectsOfType<Hand>()[0];
        }
    }
    void OnRock()
    {
        hand.Rock();
    }

    void OnPaper()
    {
        hand.Paper();
    }

    void OnScissors()
    {
        hand.Scissors();
    }
}
