using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPong : MonoBehaviour
{
    [SerializeField] public BallPong ball;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D hit)
    {
        string wallName = transform.name;
        Debug.Log(wallName);
        Debug.Log(hit.gameObject.name);
        Debug.Log(hit.gameObject.GetComponent<BallPong>().inPlay.ToString());
        PongHandler.Score(wallName);
        ball.inPlay = false;
        ball.RestartGame();
        //ball.Restart();
        //hit.gameObject.SendMessage("Restart");
        //hit.gameObject.GetComponent<BallPong>().Restart();
        //hit.gameObject.GetComponent<BallPong>().ResetBall();
        //hit.gameObject.GetComponent<BallPong>().inPlay = false;
    }
}
