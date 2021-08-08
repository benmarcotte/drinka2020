using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPong : MonoBehaviour
{
    private Vector2 originalPos;
    private Rigidbody2D rb2d;
    public float speed = 500;

    void GoBall() {
        float rand = Random.Range (0, 2);
        if (rand > 1) {
            rb2d.AddForce (new Vector2 (20, -15));
        } else {
            rb2d.AddForce (new Vector2 (-20, -15));
        }
    }

    // Use this for initialization
    void Start ()
    {
        originalPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        rb2d = GetComponent<Rigidbody2D> ();
        rb2d.velocity = Vector2.left * speed;
        Invoke ("GoBall", 3);
    }

    void ResetBall() {
        //rb2d.velocity = Vector2.right * speed;
        transform.position = originalPos;
       
    }
    void RestartGame() {
        ResetBall ();
        Invoke ("GoBall", 5);
    }
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.collider.CompareTag ("Player")) {
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
        }
    }
}
