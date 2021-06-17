using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencesDrinks : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.75f);
        text.text = text.text.Substring(text.text.IndexOf('\n') + 1);
    }

    public void failed(int amount)
    {
        text.text += "Failed after " + amount.ToString() + " successful inputs! +" + ((amount + 2) / 2).ToString() + "\n";
        StopAllCoroutines();
        StartCoroutine(wait());
    }

    public void otherSucceeded(int amount)
    {
        text.text += "Other player succeeded level " + (amount + 1).ToString() + "! +" + ((amount + 2) / 2).ToString() + "\n";
        StopAllCoroutines();
        StartCoroutine(wait());
    }

    public void failedFirst()
    {
        text.text += "Failed first input! +3" + "\n";
        StopAllCoroutines();
        StartCoroutine(wait());
    }
}
