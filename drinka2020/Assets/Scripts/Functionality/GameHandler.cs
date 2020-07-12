using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    [SerializeField] public Player[] players;   //all currently initialized players (for tourney mode, can be more than 2)
    [SerializeField] public int maxScore;
    [SerializeField] public Player rightPlayer; //currently active left or right players
    [SerializeField] public Player leftPlayer;
    [SerializeField] public bool isInOvertime;
    [SerializeField] public Minigame[] minigames;
    [SerializeField] public Minigame activeMinigame;
    public static GameHandler gameHandler;
    public static Color[] colors;

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
        }   
    }
    void Start()
    {
        colors = new Color[] { new Color(0, 1, 1, 1), new Color(0, 0, 1, 1), new Color(1, 0, 0, 1), new Color(1, 0.92f, 0.016f, 1), new Color(0, 1, 0, 1), new Color(1, 0, 1, 1) };
    }

    public void minigameEnd()
    {
        checkWin();
        SceneLoader.toIntermissionScene();

    }

    private void checkWin()
    {
        if (isInOvertime)
        {
            if (rightPlayer.score > leftPlayer.score + 1)
            {
                rightPlayer.win();
            }
            if (leftPlayer.score > rightPlayer.score + 1)
            {
                leftPlayer.win();
            }
        }
        else
        {
            if (rightPlayer.score >= maxScore)
            {
                rightPlayer.win();
            }
            if (leftPlayer.score >= maxScore)
            {
                leftPlayer.win();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
    }
}
