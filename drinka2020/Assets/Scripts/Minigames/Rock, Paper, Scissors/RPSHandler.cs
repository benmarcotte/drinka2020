using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPSHandler : MonoBehaviour
{
    [SerializeField] Hand left;
    [SerializeField] Hand right;
    [SerializeField] Text status;
    [SerializeField] Sprite rock;
    bool leftPicked = false;
    bool rightPicked = false;
    bool resolved = false;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void resolveGame()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(leftPicked && rightPicked && !resolved)
        {
            resolveGame();
            resolved = true;
        }
    }
}
