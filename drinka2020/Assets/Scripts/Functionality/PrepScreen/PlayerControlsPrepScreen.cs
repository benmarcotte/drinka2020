using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerControlsPrepScreen : MonoBehaviour
{
    public int position = 0;
    public Boolean confirmed = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if(position == -1 && PlayerAssigner.playerAssigner.leftAssigned && !confirmed)
        {
            position = 0;
        }
        if (position == 1 && PlayerAssigner.playerAssigner.rightAssigned && !confirmed)
        {
            position = 0;
        }

    }

    public void OnNavigate(InputValue value)
    {
        var v = value.Get<Vector2>();
        if(position == 0)
        {
            if (v.x > 0.3)
            {
                position = 1;
            }
            else if (v.x < -0.3)
            {
                position = -1;
            }
        } 
        else if (position == 1)
        {
            if(v.x < -0.3 && !confirmed)
            {
                position = 0;
            }
        }
        else if (position == -1)
        {
            if(v.x > 0.3 && !confirmed)
            {
                position = 0;
            }
        }
    }

    public void OnConfirm()
    {
        if (confirmed)
        {
            if(position == -1)
            {
                PlayerAssigner.playerAssigner.leftAssigned = false;
                GameHandler.gameHandler.leftPlayer = null;
            }
            else
            {
                PlayerAssigner.playerAssigner.rightAssigned = false;
                GameHandler.gameHandler.rightPlayer = null;
            }
            confirmed = false;
        }
        else if(position == -1)
        {
            PlayerAssigner.playerAssigner.leftAssigned = true;
            GameHandler.gameHandler.leftPlayer = GetComponent<Player>();
            confirmed = true;
        } 
        else if (position == 1)
        {
            PlayerAssigner.playerAssigner.rightAssigned = true;
            GameHandler.gameHandler.rightPlayer = GetComponent<Player>();
            confirmed = true;
        }
    }

    public void OnBack()
    {
        FindObjectOfType<SceneLoader>().toMainMenu();
    }

}
