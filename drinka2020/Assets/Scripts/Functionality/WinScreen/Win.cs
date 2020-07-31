using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public WinScreenCheck leftConfirmed;
    public WinScreenCheck rightConfirmed;
    public bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        leftConfirmed = GameHandler.gameHandler.leftPlayer.GetComponent<WinScreenCheck>();
        rightConfirmed = GameHandler.gameHandler.rightPlayer.GetComponent<WinScreenCheck>();
        StartCoroutine(declare());
    }

    // Update is called once per frame
    void Update()
    {
        if (leftConfirmed.confirmed && rightConfirmed.confirmed)
        {
            GameHandler.gameHandler.leftPlayer.initialize();
            GameHandler.gameHandler.rightPlayer.initialize();
            SceneLoader.sceneLoader.toPrepScene();
        }
    }

    IEnumerator declare()
    {
        GetComponent<Text>().text = "The winner is.";
        yield return new WaitForSeconds(0.7f);
        GetComponent<Text>().text = "The winner is..";
        yield return new WaitForSeconds(0.7f);
        GetComponent<Text>().text = "The winner is...";
        yield return new WaitForSeconds(1.4f);
        started = true;
        GetComponent<Text>().text = "Congratulations " + GameHandler.gameHandler.winner.playerName + "!";
        GetComponentInChildren<Image>().enabled = true;
        GetComponentInChildren<Image>().color = GameHandler.gameHandler.winner.color;
    }
}
