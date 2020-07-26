using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckOfCards : MonoBehaviour
{
    public Card cardPrefab;
    Card card;
    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= 13; j++)
            {
                cardPrefab.value = j;
                cardPrefab.suit = i;
                card = Instantiate(cardPrefab, gameObject.transform);
                card.transform.SetParent(gameObject.transform);
            }
        }
        cardPrefab.value = 14;
        cardPrefab.suit = 1;
        card = Instantiate(cardPrefab, gameObject.transform);
        card.transform.SetParent(gameObject.transform);
        cardPrefab.value = 14;
        cardPrefab.suit = 2;
        card = Instantiate(cardPrefab, gameObject.transform);
        card.transform.SetParent(gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
