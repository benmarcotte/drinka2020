using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Intermission : MonoBehaviour
{
    [SerializeField] InputActionAsset actions;
    // Start is called before the first frame update
    void Start()
    {
        GameHandler.gameHandler.leftPlayer.GetComponent<PlayerInput>().actions = actions;
        GameHandler.gameHandler.rightPlayer.GetComponent<PlayerInput>().actions = actions;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
