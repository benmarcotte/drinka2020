using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayerManager : MonoBehaviour
{
    public int playerCount;

    private void Awake()
    {
        int playerManagers = FindObjectsOfType<NewPlayerManager>().Length;
        if(playerManagers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerJoined()
    {
        this.playerCount++;
    }

    public void OnPlayerLeft()
    {
        this.playerCount--;
    }
}
