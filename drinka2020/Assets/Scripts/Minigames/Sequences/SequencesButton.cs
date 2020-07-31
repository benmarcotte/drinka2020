using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencesButton : MonoBehaviour
{
    public bool active;
    public bool pressed;
    public char button;
    public Image image;
    public Sprite x;
    public Sprite square;
    public Sprite triangle;
    public Sprite circle;
    public Sprite l1;
    public Sprite r1;
    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        x = Resources.Load<Sprite>("Sprites/Sequences/button_cross");
        circle = Resources.Load<Sprite>("Sprites/Sequences/button_circle");
        square = Resources.Load<Sprite>("Sprites/Sequences/button_square");
        triangle = Resources.Load<Sprite>("Sprites/Sequences/button_triangle");
        r1 = Resources.Load<Sprite>("Sprites/Sequences/bumper1_r1");
        l1 = Resources.Load<Sprite>("Sprites/Sequences/bumper1_l1");

    }

    public void setButton(char c)
    {
        switch (c)
        {
            case 'n':
                button = 'n';
                image.sprite = triangle;
                break;

            case 'e':
                button = 'e';
                image.sprite = circle;
                break;

            case 's':
                button = 's';
                image.sprite = x;
                break;

            case 'w':
                button = 'w';
                image.sprite = square;
                break;

            case 'l':
                button = 'l';
                image.sprite = l1;
                break;

            case 'r':
                button = 'r';
                image.sprite = r1;
                break;
        }
    }

    public void succeeded()
    {
        pressed = true;
        image.sprite = Resources.Load<Sprite>("Sprites/check");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
