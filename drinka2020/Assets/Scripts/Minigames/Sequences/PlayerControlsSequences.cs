using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsSequences : MonoBehaviour, IPlayerControls
{
    public SequencesPanel panel;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.GetComponent<Player>() == GameHandler.gameHandler.leftPlayer)
        {
            panel = FindObjectsOfType<SequencesPanel>()[1];
        }
        else
        {
            panel = FindObjectsOfType<SequencesPanel>()[0];
        }
    }

    public void OnSouth()
    {
        panel.checkInput('s');
    }

    public void OnNorth()
    {
        panel.checkInput('n');
    }

    public void OnEast()
    {
        panel.checkInput('e');
    }

    public void OnWest()
    {
        panel.checkInput('w');
    }

    public void OnLB()
    {
        panel.checkInput('l');
    }

    public void OnRB()
    {
        panel.checkInput('r');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
