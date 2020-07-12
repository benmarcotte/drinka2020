using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrepAssigner : MonoBehaviour
{
    public Player player;
    [SerializeField] public int playerNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            player = FindObjectsOfType<Player>()[FindObjectsOfType<Player>().Length - playerNumber];
            GetComponent<Image>().color = player.color;
        } 
        catch(System.Exception e)
        {

        }
     
    }
}
