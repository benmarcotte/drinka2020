using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsWar : MonoBehaviour
{
    public Player player;
    WarHandler warHandler;
    WarDrinks warDrinks;
    public bool fumbled = false;
    public bool succeeded = false;
    // Start is called before the first frame update
    void Start()
    {
        warHandler = WarHandler.warHandler;
        if (player == GameHandler.gameHandler.leftPlayer)
        {
            warDrinks = FindObjectsOfType<WarDrinks>()[1];
        }
        else
        {
            warDrinks = FindObjectsOfType<WarDrinks>()[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDraw()
    {
        if (!warHandler.timingActive && warHandler.countdownStarted && !fumbled)
        {
            fumbled = true;
            warDrinks.fumbled();
            player.drinks++;
        }
        else if (warHandler.timingActive && !fumbled)
        {
            succeeded = true;
            warHandler.sendCard(player);
        }
    }
}
