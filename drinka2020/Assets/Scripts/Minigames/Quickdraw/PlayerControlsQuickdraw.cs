using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlsQuickdraw : MonoBehaviour
{
    public Player player;
    public Image gunImage;
    public Text timerDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Player>();
        if(player == GameHandler.gameHandler.leftPlayer)
        {
            gunImage = FindObjectsOfType<Draw>()[0].gameObject.GetComponent<Image>();
        }
        else
        {
            gunImage = FindObjectsOfType<Draw>()[1].gameObject.GetComponent<Image>();
        }
        timerDisplay = gunImage.gameObject.GetComponentInChildren<Text>();
        gunImage.enabled = true;
        gunImage.color = player.color;
        gunImage.enabled = false;
    }

    public void OnShoot()
    {
        if (QuickdrawHandler.quickdrawHandler.started)
        {
            if (QuickdrawHandler.quickdrawHandler.tricked)
            {
                QuickdrawHandler.quickdrawHandler.gotTricked(player);
            }
            gunImage.enabled = true;
            if (!QuickdrawHandler.quickdrawHandler.drawn && !QuickdrawHandler.quickdrawHandler.someoneShot)
            {
                QuickdrawHandler.quickdrawHandler.someoneShot = true;
                QuickdrawHandler.quickdrawHandler.lostByEarlyShot(player);
                QuickdrawHandler.quickdrawHandler.drawText.enabled = false;
            }
            else if (QuickdrawHandler.quickdrawHandler.drawn)
            {
                timerDisplay.text = QuickdrawHandler.quickdrawHandler.timer.ElapsedMilliseconds.ToString() + "ms";
                if (!QuickdrawHandler.quickdrawHandler.someoneShot)
                {
                    QuickdrawHandler.quickdrawHandler.someoneShot = true;
                    QuickdrawHandler.quickdrawHandler.wonDraw(player);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
