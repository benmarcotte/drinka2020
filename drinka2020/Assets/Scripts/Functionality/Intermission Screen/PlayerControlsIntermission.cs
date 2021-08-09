using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsIntermission : MonoBehaviour
{
    public Player player;
    public IntermissionCountdown countdown;
    // Start is called before the first frame update
    void Start()
    {
        countdown = FindObjectOfType<IntermissionCountdown>();
        player = gameObject.GetComponent<Player>();
    }

    // Update is called once per frame

    public void OnDraw()
    {
        if (countdown.started)
        {
            player.drinks--;
        }
    }
}
