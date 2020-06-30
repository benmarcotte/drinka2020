using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    public string color;


    private void Awake()
    {
        int playerCount;
    }
    void Start()
    {
        
    }

    public void addScore(int score)
    {
        this.score = this.score + score;
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
