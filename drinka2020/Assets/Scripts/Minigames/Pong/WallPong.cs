using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPong : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Ball")
        {
            string wallName = transform.name;
            PongHandler.Score(wallName);
            hit.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
