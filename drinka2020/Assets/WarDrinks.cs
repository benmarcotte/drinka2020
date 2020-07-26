using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarDrinks : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lost()
    {
        text.text += "Lost! +1\n";
        StartCoroutine(wait());
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(0.75f);
        text.text = "";
    }

    public void drewJoker()
    {
        text.text += "Drew Joker! +5\n";
        StartCoroutine(wait());
    }

    public void lostWar(int count)
    {
        text.text += text.text + "Lost war! +" + count.ToString() + "\n";
        StartCoroutine(wait());
    }
}
