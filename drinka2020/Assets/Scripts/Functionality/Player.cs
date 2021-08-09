using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    public string character;
    public string[] characters = { "Mace", "Whip", "Gottem" };
    public int characterInt;
    

    //implement controller assignment



    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Prep Screen") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main Menu"))
        {
            gameObject.AddComponent<PlayerControlsPrepScreen>();
        }
    }
    void Start()
    {
        SceneManager.activeSceneChanged += ChangePlayerControls;
        GameHandler.gameHandler.players = FindObjectsOfType<Player>();
        playerNumber = FindObjectsOfType<Player>().Length;
        initialize();
    }

    public void initialize()
    {
        score = 0;
        drinks = 0;

        if (giveColor)
        {
            if (GameHandler.gameHandler.players.Length == 1)
            {
                colorInt = UnityEngine.Random.Range(0, GameHandler.colors.Length);
                color = GameHandler.colors[colorInt];
                characterInt = UnityEngine.Random.Range(0, characters.Length);
                character = characters[characterInt];
                playerName = GameHandler.colorNames[colorInt];
            }
            else
            {
                colorInt = UnityEngine.Random.Range(0, GameHandler.colors.Length);
                characterInt = UnityEngine.Random.Range(0, characters.Length);
                while (checkMatchingParameters())
                {
                    colorInt = UnityEngine.Random.Range(0, GameHandler.colors.Length);
                    characterInt = UnityEngine.Random.Range(0, characters.Length);

                }
                color = GameHandler.colors[colorInt];
                character = characters[characterInt];
                playerName = GameHandler.colorNames[colorInt];
            }
        }
    }

    public bool checkMatchingParameters()
    {
        for(int i = 0; i < GameHandler.gameHandler.players.Length; i++)
        {
            if(gameObject.GetComponent<Player>() != GameHandler.gameHandler.players[i] && (colorInt == GameHandler.gameHandler.players[i].colorInt || characterInt == GameHandler.gameHandler.players[i].characterInt))
            {
                return true;
            }
        }
        return false;
    }

    public void ChangePlayerControls(Scene current, Scene next)
    {
        Debug.Log(current.name + ": " + next.name);
        if (current == SceneManager.GetSceneByName("Prep Screen") || current == SceneManager.GetSceneByName("Main Menu"))
        {
            Destroy(gameObject.GetComponent<PlayerControlsPrepScreen>());
        }
        else if (current == SceneManager.GetSceneByName("War"))
        {
            Destroy(gameObject.GetComponent<PlayerControlsWar>());
        }
        else if (current == SceneManager.GetSceneByName("Intermission"))
        {
            Destroy(gameObject.GetComponent<PlayerControlsIntermission>());
        }
        else if (current == SceneManager.GetSceneByName("Sequences"))
        {
            Destroy(gameObject.GetComponent<PlayerControlsSequences>());
        }
        else if (current == SceneManager.GetSceneByName("Win"))
        {
            Destroy(gameObject.GetComponent<WinScreenCheck>());
        }
        else if(current == SceneManager.GetSceneByName("Tug of War"))
        {
            Destroy(gameObject.GetComponent<PlayerControlsTugOfWar>());
        }
        else if (current == SceneManager.GetSceneByName("Rock, Paper, Scissors"))
        {
            Destroy(gameObject.GetComponent<PlayerControlsRockPaperScissors>());
        }
        else if (next == SceneManager.GetSceneByName("Pong"))
        {
            Destroy(gameObject.AddComponent<PlayerControlsPong>());
        }

        //Everything above destroys current controller component
        //Everything under adds its own controller component

        if (next == SceneManager.GetSceneByName("Intermission"))
        {
            gameObject.AddComponent<PlayerControlsIntermission>();
            gameObject.GetComponent<PlayerControlsIntermission>().player = gameObject.GetComponent<Player>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("War");
        }
        else if (next == SceneManager.GetSceneByName("Win"))
        {
            gameObject.AddComponent<WinScreenCheck>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("War");
        }
        else if (next == SceneManager.GetSceneByName("War"))
        {
            gameObject.AddComponent<PlayerControlsWar>();
            gameObject.GetComponent<PlayerControlsWar>().player = gameObject.GetComponent<Player>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("War");
        }
        else if (next == SceneManager.GetSceneByName("Main Menu"))
        {
            Destroy(gameObject.gameObject);
        }
        else if (next == SceneManager.GetSceneByName("Quickdraw"))
        {
            gameObject.AddComponent<PlayerControlsQuickdraw>();
            gameObject.GetComponent<PlayerControlsQuickdraw>().player = gameObject.GetComponent<Player>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("Quickdraw");
        }
        else if (next == SceneManager.GetSceneByName("Sequences"))
        {
            gameObject.AddComponent<PlayerControlsSequences>();
            //gameObject.GetComponent<PlayerControlsSequences>().player = gameObject.GetComponent<Player>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("Sequences");
        }
        else if (next == SceneManager.GetSceneByName("Prep Screen"))
        {
            gameObject.AddComponent<PlayerControlsPrepScreen>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("UI");
        }
        else if (next == SceneManager.GetSceneByName("Tug of War"))
        {
            gameObject.AddComponent<PlayerControlsTugOfWar>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("Tug of War");
        }
        else if (next == SceneManager.GetSceneByName("Rock, Paper, Scissors"))
        {
            gameObject.AddComponent<PlayerControlsRockPaperScissors>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("Rock Paper Scissors");
        }
        else if (next == SceneManager.GetSceneByName("Pong"))
        {
            gameObject.AddComponent<PlayerControlsPong>();
            gameObject.GetComponent<PlayerInput>().SwitchCurrentActionMap("Pong");
        }
    }
}
