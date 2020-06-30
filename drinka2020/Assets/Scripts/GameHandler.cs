using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    [SerializeField] public Player[] players;
    // Start is called before the first frame update

    private void Awake()
    {
        int gameHandlerCount = FindObjectsOfType<GameHandler>().Length;
        if(gameHandlerCount > 1)
        {
            Destroy(gameObject);
        } 
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
