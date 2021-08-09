using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddlePong : MonoBehaviour
{

    //public KeyCode moveUpKb = KeyCode.W;
    //public KeyCode moveDownKb = KeyCode.S;
    //public KeyCode moveUpCon = KeyCode.JoystickButton3;
    //public KeyCode moveDownCon = KeyCode.JoystickButton1;
    public float speed = 300f;
    [SerializeField] public RectTransform topWall;
    [SerializeField] public RectTransform bottomWall;
    public float boundTop = 430f;
    public float boundBottom = 80f;
    private Rigidbody2D rb2d;
    public bool pressedUp = false;
    public bool pressedDown = false;

    // Use this for initialization
    void Start () {
        boundTop = topWall.position.y;
        boundBottom = bottomWall.position.y;
        rb2d = GetComponent<Rigidbody2D> ();
    }

    public void Up(InputAction.CallbackContext obj)
    {
        var vel = rb2d.velocity;
        if (obj.started)
        {
            vel.y = speed;
        }
        if (obj.canceled)
        {
            vel = new Vector2(0, 0);
        }
    }
    public void Down(InputAction.CallbackContext obj)
    {
        var vel = rb2d.velocity;
        if (obj.started)
        {
            vel.y = -speed;
        }
        if (obj.canceled)
        {
            vel = new Vector2(0, 0);
        }
    }


    private void FixedUpdate()
    {
        var vel = rb2d.velocity;
        if (pressedUp)
        {
            vel.y = speed;
        }
        else if (pressedDown)
        {
            vel.y = -speed;
        }
        else 
        {
            vel = new Vector2(0, 0);
        }
        rb2d.velocity = vel;
    }

    // Update is called once per frame
    void Update () {
        //var vel = rb2d.velocity;
        //if (Input.GetKey (moveUpKb) || Input.GetKey(moveUpCon)) {
        //    vel.y = speed;
        //} else if (Input.GetKey (moveDownKb) || Input.GetKey(moveDownCon)) {
        //    vel.y = -speed;
        //} else if (!Input.anyKey) {
        //    vel.y = 0;
        //}
        //rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundTop) {
            pos.y = boundTop;
        } else if (pos.y < boundBottom) {
            pos.y = boundBottom;
        }
        transform.position = pos;
    }
    
    
    
}
