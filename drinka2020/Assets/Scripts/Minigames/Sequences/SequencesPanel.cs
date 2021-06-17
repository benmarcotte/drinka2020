using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencesPanel : MonoBehaviour
{
    public Player player;
    public Player enemyPlayer;
    public int playerNumber;
    public SequencesButton[] buttons;
    public int level = 0;
    public int nextButton = 0;
    public char[] chars = { 's', 'e', 'n', 'w', 'l', 'r' };
    public int amountPressed = 0;
    public SequencesDrinks ourDrinks;
    public SequencesDrinks enemyDrinks;
    // Start is called before the first frame update
    void Start()
    {
        if (playerNumber == 0)
        {
            player = GameHandler.gameHandler.leftPlayer;
            enemyPlayer = GameHandler.gameHandler.rightPlayer;
        }
        else
        {
            player = GameHandler.gameHandler.rightPlayer;
            enemyPlayer = GameHandler.gameHandler.leftPlayer;
        }
        gameObject.GetComponent<Image>().color = new Color(player.color.r, player.color.g, player.color.b, 100f/255f);
        buttons = GetComponentsInChildren<SequencesButton>();
    }

    public IEnumerator setup()
    {
        for (int i = 0; i <= level; i++)
        {
            buttons[i].image.enabled = true;
            yield return new WaitForEndOfFrame();
            buttons[i].active = true;
            buttons[i].pressed = false;
            buttons[i].setButton(chars[Random.Range(0, chars.Length)]);
        }
    }

    public void checkInput(char input)
    {
        if (SequencesCountdown.sequencesCountdown.started)
        {
            if (input == buttons[nextButton].button)
            {
                buttons[nextButton].succeeded();
                amountPressed++;
                if(nextButton < level)
                {
                    nextButton++; 
                }
                else
                {
                    nextButton = 0;
                    enemyDrinks.otherSucceeded(level);
                    enemyPlayer.drinks += (level + 2) / 2;
                    amountPressed = 0;
                    if (level < 9)
                    {
                        level++;
                    } 
                    StartCoroutine(setup());
                }
            }
            else
            {
                if(amountPressed == 0)
                {
                    ourDrinks.failedFirst();
                    player.drinks += 3;
                }
                else
                {
                    ourDrinks.failed(amountPressed);
                    player.drinks += (amountPressed + 2) / 2;
                }
                nextButton = 0;
                amountPressed = 0;
                StartCoroutine(setup());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
