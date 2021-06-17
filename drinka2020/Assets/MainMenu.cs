using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem.SetSelectedGameObject(gameObject);
        eventSystem.UpdateModules();
    }

    // Update is called once per frame
    void Update()
    {
        eventSystem.UpdateModules();
    }
}
