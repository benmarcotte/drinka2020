using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MinigameSelector : MonoBehaviour
{
    //[SerializeField] Minigame[] minigames;
    [SerializeField] GameHandler gameHandler;
    [SerializeField] GameObject toggle;
    //[SerializeField] Toggle[] toggles;
    void Start()
    {
        //gameHandler = FindObjectOfType<GameHandler>();
        //minigames = gameHandler.minigames;
        //toggles = new Toggle[minigames.Length];
        for(int i = 0; i < gameHandler.minigames.Length; i++)
        {
            UnityEngine.UIElements.Toggle toggle = new UnityEngine.UIElements.Toggle();
            toggle.name = gameHandler.minigames[i].gameName;
            this.Add(new UnityEngine.UIElements.Toggle());
            //GameObject toggle = new GameObject();
            //toggle.transform.SetParent(gameObject.transform);
            //toggle.name = minigames[i].gameName;
            //toggle.GetChild(0).sizeDelta = new Vector2(23, 23);
            //toggles[i] = gameObject.AddComponent<Toggle>();
            //toggles[i].enabled = true;
            //toggles[i].name = minigames[i].gameName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
