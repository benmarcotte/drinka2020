using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameSelector : MonoBehaviour
{
    [SerializeField] Minigame[] minigames;
    [SerializeField] GameHandler gameHandler;
    [SerializeField] Toggle[] toggles;
    void Start()
    {
        gameHandler = FindObjectOfType<GameHandler>();
        minigames = gameHandler.minigames;
        toggles = new Toggle[minigames.Length];
        for(int i = 0; i < minigames.Length; i++)
        {
            toggles[i] = gameObject.AddComponent<Toggle>();
            toggles[i].enabled = true;
            toggles[i].name = minigames[i].gameName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
