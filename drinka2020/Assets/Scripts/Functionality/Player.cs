using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms;

public class Player : MonoBehaviour
{
    public UnityEngine.Color color;
    public int score;
    public int drinks;
    public int playerNumber;
    public GameHandler gameHandler = GameHandler.gameHandler;
    public int colorInt;

    //implement controller assignment

    public Player()
    {
        this.score = 0;
    }

    private void Awake()
    {
        
    }
    void Start()
    {
        GameHandler.gameHandler.players = FindObjectsOfType<Player>();
        playerNumber = FindObjectsOfType<Player>().Length;
        if (GameHandler.gameHandler.players.Length == 1)
        {
            colorInt = UnityEngine.Random.Range(0, GameHandler.colors.Length);
            color = GameHandler.colors[colorInt];
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
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void win()
    {
        throw new NotImplementedException();
    }
}
