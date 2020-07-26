using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().color = new Color(0, 0, 0, 0);
        StartCoroutine(declare());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator declare()
    {
        GetComponent<Text>().text = "The winner is.";
        yield return new WaitForSeconds(0.7f);
        GetComponent<Text>().text = "The winner is..";
        yield return new WaitForSeconds(0.7f);
        GetComponent<Text>().text = "The winner is...";
        yield return new WaitForSeconds(1.4f);
        GetComponent<Text>().text = "Congratulations " + GameHandler.gameHandler.winner.playerName + "!";
        GetComponentInChildren<Image>().color = GameHandler.gameHandler.winner.color;
    }
}
