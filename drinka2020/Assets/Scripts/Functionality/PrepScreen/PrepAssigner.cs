using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrepAssigner : MonoBehaviour
{
    public Player player;
    public PlayerControlsPrepScreen controls;
    [SerializeField] public int playerNumber;
    [SerializeField] public Text left;
    [SerializeField] public Text right;
    [SerializeField] public Sprite check;
    public float initialPos;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            player = FindObjectsOfType<Player>()[FindObjectsOfType<Player>().Length - playerNumber];
            GetComponent<Image>().color = player.color;
            controls = player.GetComponent<PlayerControlsPrepScreen>();

        } 
        catch(System.Exception e)
        {

        }
        if (controls.confirmed)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/check");
        }
        if (!controls.confirmed)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/button_a");
        }
        if(controls.position == -1 && !controls.confirmed)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(left.transform.position.x, gameObject.transform.position.y), 100);
        }
        else if(controls.position == 1 && !controls.confirmed)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(right.transform.position.x, gameObject.transform.position.y), 100);
        }
        else if(controls.position == 0 && !controls.confirmed)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(initialPos, gameObject.transform.position.y), 100);
        }
    }
}
