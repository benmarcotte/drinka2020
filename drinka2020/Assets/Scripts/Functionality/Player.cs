using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public string color;
    public int score;

    //implement controller assignment

    public Player()
    {
        this.score = 0;
    }

    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void win()
    {
        throw new NotImplementedException();
    }
}
