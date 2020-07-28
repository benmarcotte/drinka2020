using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class Player : MonoBehaviour
{
    public UnityEngine.Color color;
    public int score;
    public int drinks;
    public int playerNumber;
    public GameHandler gameHandler = GameHandler.gameHandler;
    public int colorInt;
    public bool giveColor;
    public string playerName;

    //implement controller assignment

    

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        SceneManager.activeSceneChanged += ChangePlayerControls;
        score = 0;
        drinks = 0;
        GameHandler.gameHandler.players = FindObjectsOfType<Player>();
        playerNumber = FindObjectsOfType<Player>().Length;
        if (giveColor)
        {
            if (GameHandler.gameHandler.players.Length == 1)
            {
                colorInt = UnityEngine.Random.Range(0, GameHandler.colors.Length);
                color = GameHandler.colors[colorInt];
                playerName = GameHandler.colorNames[colorInt];
            }
            else
            {
                colorInt = UnityEngine.Random.Range(0, GameHandler.colors.Length);
                for(int i = 0; i < GameHandler.gameHandler.players.Length; i++)
                {
                    if(colorInt == GameHandler.gameHandler.players[i].colorInt)
                    {
                        if(colorInt+1 == GameHandler.colors.Length)
                        {
                            colorInt = 0;
                        }
                        else
                        {
                            colorInt = UnityEngine.Random.Range(0, GameHandler.colors.Length);
                        }
                    }
                }
                color = GameHandler.colors[colorInt];
                playerName = GameHandler.colorNames[colorInt];
            }
        }
    }

    public void ChangePlayerControls(Scene current, Scene next)
    {
        Debug.Log("scene changed");
        if (current == SceneManager.GetSceneByName("Prep Screen"))
        {
            Destroy(gameObject.GetComponent<PlayerControlsPrepScreen>());
        }


        if (next == SceneManager.GetSceneByName("War"))
        {
            gameObject.AddComponent<PlayerControlsWar>();
            gameObject.GetComponent<PlayerControlsWar>().player = gameObject.GetComponent<Player>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("War");
            //GetComponent<PlayerInput>().actions = Resources.Load<InputActionAsset>("Input Settings/War");
        }
    }
}
