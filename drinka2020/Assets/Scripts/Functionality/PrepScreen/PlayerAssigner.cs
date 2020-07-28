using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Composites;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerAssigner : MonoBehaviour
{
    public Boolean leftAssigned = false;
    public Boolean rightAssigned = false;
    public Boolean countdownStarted = false;
    public static PlayerAssigner playerAssigner;
    public int i;
    public PlayerInputManager playerInputManager;

    // Start is called before the first frame update
    private void Awake()
    {
        FindObjectOfType<PlayerInputManager>().GetComponent<PlayerInputManager>().playerPrefab.GetComponent<PlayerInput>().actions = Resources.Load<InputActionAsset>("Input Settings/prepScreen");
    }
    void Start()
    {
        playerInputManager = FindObjectOfType<PlayerInputManager>();
        FindObjectOfType<PlayerInputManager>().GetComponent<PlayerInputManager>().playerPrefab.GetComponent<PlayerInput>().actions = Resources.Load<InputActionAsset>("Input Settings/prepScreen");
        playerAssigner = FindObjectOfType<PlayerAssigner>();
        int i = UnityEngine.Random.Range(0, GameHandler.gameHandler.minigames.Length);
        GameHandler.gameHandler.activeMinigame = GameHandler.gameHandler.minigames[7];
    }

    // Update is called once per frame
    void Update()
    {
        if(leftAssigned && rightAssigned && !countdownStarted)
        {
            countdownStarted = true;
            StartCoroutine(StartCountdown());
        }
        else if (!leftAssigned || !rightAssigned)
        {
            countdownStarted = false;
            i = 3;
            StopAllCoroutines();
            GetComponent<Text>().text = "Ready Up";
        }
    }

    IEnumerator StartCountdown()
    {
        while (i >= 0)
        {
            if (i != 0)
            {
                GetComponent<Text>().text = i.ToString();
                yield return new WaitForSeconds(1f);
                i--;
            }
            else
            {
                GetComponent<Text>().text = "First Game: " + GameHandler.gameHandler.activeMinigame.gameName + "!";
                yield return new WaitForSeconds(1f);
                i--;
                FindObjectOfType<SceneLoader>().startGame();
            }
        }
    }
}
