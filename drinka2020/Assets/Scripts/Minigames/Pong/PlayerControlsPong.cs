using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControlsPong : MonoBehaviour
{
    public PaddlePong paddle;
    
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.GetComponent<Player>() == GameHandler.gameHandler.leftPlayer)
        {
            paddle = FindObjectsOfType<PaddlePong>()[0];
        }
        else
        {
            paddle = FindObjectsOfType<PaddlePong>()[1];
        }
    }

    void OnUp()
    {
        //paddle.Up(obj);
        paddle.UpStart();
        //paddle.pressedUp = !paddle.pressedUp;
    }

    void OnDown()
    {
        paddle.DownStart();
    }

    void OnUpRelease()
    {
        paddle.UpStop();
    }

    void OnDownRelease()
    {
        //paddle.Down(obj);
        paddle.DownStop();
        //    //paddle.pressedDown = !paddle.pressedUp;
    }

        // Update is called once per frame
        void Update()
    {
    }
}
