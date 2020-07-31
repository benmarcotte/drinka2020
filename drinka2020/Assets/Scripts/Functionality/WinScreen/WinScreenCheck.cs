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
    public Win win;
    public Image check;
    // Start is called before the first frame update
    void Start()
    {
        win = FindObjectOfType<Win>();
        player = gameObject.GetComponent<Player>();
        if (player == GameHandler.gameHandler.leftPlayer)
        {
            check = win.GetComponentsInChildren<check>()[0].gameObject.GetComponent<Image>();
        }
        else
        {
            check = win.GetComponentsInChildren<check>()[1].gameObject.GetComponent<Image>();
        }
        GetComponent<Image>().color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (confirmed)
        {
            check.color = player.color;
        }
        else
        {
            check.color = new Color(0, 0, 0, 0);
        }
    }

    public void OnDraw()
    {
        if (win.started)
        {
            confirmed = !confirmed;
        }
    }
}
