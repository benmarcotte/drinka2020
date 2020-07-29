using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntermissionCountdown : MonoBehaviour
{
    public float currentTime;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = GameHandler.gameHandler.sipThreshold;
        GetComponent<Text>().text = currentTime.ToString();
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while(currentTime > 0)
        {
        currentTime -= 0.01f;
        yield return new WaitForSeconds(0.01f);
        }
        SceneManager.LoadScene("Next Game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
