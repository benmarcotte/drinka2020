using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsTugOfWar : MonoBehaviour
{
    public Player player;
    public char side;
    void Start()
    {
        player = gameObject.GetComponent<Player>();
        if(player == GameHandler.gameHandler.leftPlayer)
        {
            side = 'l';
        }
        else
        {
            side = 'r';
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPull()
    {
        TugOfWarHandler.tugOfWarHandler.someonePulled(side);
    }
}
