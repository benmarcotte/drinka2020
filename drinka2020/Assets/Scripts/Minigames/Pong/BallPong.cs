using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPong : MonoBehaviour
{
    [SerializeField] private Vector2 originalPos;
    private Rigidbody2D rb2d;
    public float speed = 500;
    public bool inPlay = false;

    void GoBall() {
        float rand = Random.Range (0, 2);
        if (rand < 1) {
            rb2d.velocity = new Vector2(-speed, Random.Range(-200, 201));
        } else {
            rb2d.velocity = new Vector2(speed, Random.Range(-200, 201));
        }
        inPlay = true;
    }

    // Use this for initialization
    void Start ()
    {
        originalPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        rb2d = GetComponent<Rigidbody2D> ();
        Invoke ("GoBall", 2);
    }

    public void ResetBall() {
        //rb2d.velocity = Vector2.right * speed;
        transform.position = originalPos;
        rb2d.velocity = new Vector2(0f, 0f);
    }

    public void RestartGame() {
        Debug.Log("restartying");
        ResetBall ();
        Invoke ("GoBall", 1);
    }
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.collider.CompareTag ("Left Player") || coll.collider.CompareTag("Right Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x*1.2f;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
        }
        if (coll.collider.CompareTag("Left Player"))
        {
            PongHandler.pongHandler.leftDrinks.Pong();
        }
        if (coll.collider.CompareTag("Right Player"))
        {
            PongHandler.pongHandler.rightDrinks.Pong();
        }
    }
}
