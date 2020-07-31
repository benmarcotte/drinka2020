using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    public Player[] players;   //all currently initialized players (for tourney mode, can be more than 2)
    public int maxScore;
    public int sipThreshold = 10;
    public Player rightPlayer; //currently active left or right players
    public Player leftPlayer;
    public bool isInOvertime;
    [SerializeField] public Minigame[] minigames;
    public Minigame activeMinigame;
    public static GameHandler gameHandler;
    public static Color[] colors;
    public static string[] colorNames;
    public Player winner;
    public int rounds;


    // Start is called before the first frame update

    private void Awake()
    {
        int gameHandlerCount = FindObjectsOfType<GameHandler>().Length;
        if (gameHandlerCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            gameHandler = gameObject.GetComponent<GameHandler>();
            DontDestroyOnLoad(gameObject);
            gameHandler = FindObjectOfType<GameHandler>();
        }   
    }
    void Start()
    {
        rounds = 0;
        colors = new Color[] { new Color(0, 1, 1, 1), new Color(0.1f, 0.1f, 1, 1), new Color(1, 0.1f, 0.1f, 1), new Color(1, 0.92f, 0.016f, 1), new Color(0, 1, 0, 1), new Color(1, 0, 1, 1), new Color(0, 1, 0.5f), new Color(1, 0.6f, 1), new Color(1, 0.5f, 0) };
        colorNames = new string[] { "Cyan", "Blue", "Red", "Yellow", "Green", "Magenta", "Teal", "Pink", "Orange" };
    }

    public void minigameEnd()
    {
        //checkWin();
        SceneLoader.sceneLoader.toNextScreen();

    }

    private void checkWin()
    {
        if (isInOvertime)
        {
            if (rightPlayer.score > leftPlayer.score + 1)
            {
                win(rightPlayer);
            }
            if (leftPlayer.score > rightPlayer.score + 1)
            {
                win(leftPlayer);
            }
        }
        else
        {
            if (rightPlayer.score >= maxScore)
            {
                win(rightPlayer);
            }
            if (leftPlayer.score >= maxScore)
            {
                win(leftPlayer);
            }
        }
    }

    public void win(Player player)
    {
        winner = player;
        SceneLoader.sceneLoader.toWinScene();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
