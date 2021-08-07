using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsPong : MonoBehaviour
{

    public KeyCode moveUpKb = KeyCode.W;
    public KeyCode moveDownKb = KeyCode.S;
    public KeyCode moveUpCon = KeyCode.JoystickButton3;
    public KeyCode moveDownCon = KeyCode.JoystickButton1;
    public float speed = 300f;
    public float boundTop = 430f;
    public float boundBottom = 80f;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
    }
	
    // Update is called once per frame
    void Update () {
        var vel = rb2d.velocity;
        if (Input.GetKey (moveUpKb) || Input.GetKey(moveUpCon)) {
            vel.y = speed;
        } else if (Input.GetKey (moveDownKb) || Input.GetKey(moveDownCon)) {
            vel.y = -speed;
        } else if (!Input.anyKey) {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundTop) {
            pos.y = boundTop;
        } else if (pos.y < boundBottom) {
            pos.y = boundBottom;
        }
        transform.position = pos;
    }
    
    
    
}
