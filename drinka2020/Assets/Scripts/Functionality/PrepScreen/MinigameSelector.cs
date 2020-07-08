using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MinigameSelector : MonoBehaviour
{
    //[SerializeField] Minigame[] minigames;
    [SerializeField] UnityEngine.UI.Toggle toggle;
    [SerializeField] UnityEngine.UI.Image toggleParent;
    //[SerializeField] Toggle[] toggles;
    void Start()
    {
        float pivotX = 0;
        float pivotY = 1;
        //gameHandler = FindObjectOfType<GameHandler>();
        //minigames = gameHandler.minigames;
        //toggles = new Toggle[minigames.Length];
        for (int i = 0; i < GameHandler.gameHandler.minigames.Length; i++)
        {
            UnityEngine.UI.Toggle newToggle = Instantiate(toggle, toggleParent.transform);
            newToggle.name = GameHandler.gameHandler.minigames[i].gameName;
            
            //GameObject toggle = new GameObject();
            newToggle.transform.SetParent(toggleParent.transform);
            newToggle.GetComponent<UnityEngine.UI.Toggle>().GetComponentInChildren<Text>().text = GameHandler.gameHandler.minigames[i].gameName;
            newToggle.transform.localPosition = new Vector2(pivotX, pivotY);
            pivotY = pivotY - newToggle.GetComponent<RectTransform>().sizeDelta.y;
            //toggles[i] = gameObject.AddComponent<Toggle>();
            //toggles[i].enabled = true;
            //toggles[i].name = minigames[i].gameName;
        }
        var parentRect = toggleParent.GetComponent<RectTransform>();
        parentRect.sizeDelta = new Vector2(parentRect.sizeDelta.x, Mathf.Abs(pivotY));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
