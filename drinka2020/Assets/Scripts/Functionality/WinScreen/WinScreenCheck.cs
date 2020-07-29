using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class WinScreenCheck : MonoBehaviour
{
    [SerializeField] public int playerNumber;
    public Player player;
    public bool confirmed;
    [SerializeField] public InputActionAsset actions;
    // Start is called before the first frame update
    void Start()
    {
        player = GameHandler.gameHandler.players[playerNumber];
        GetComponent<Image>().color = new Color(0, 0, 0, 0);
        player.GetComponent<PlayerInput>().actions = actions;
    }

    // Update is called once per frame
    void Update()
    {
        if (confirmed)
        {
            GetComponent<Image>().color = player.color;
        }
        else
        {
            GetComponent<Image>().color = new Color(0, 0, 0, 0);
        }
    }

    void OnSip()
    {
        confirmed = !confirmed;
    }
}
