using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickdrawDrinks : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    public void shotEarly()
    {
        text.text += "Dishonorable gunsligner! +15\n";
    }

    public void gotShot()
    {
        text.text += "Got Shot! +5\n";
    }

    public void gotTricked()
    {
        text.text += "Tricked! +5\n";
    }

    public void lost()
    {
        text.text += "Lost the duel! +5\n";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
