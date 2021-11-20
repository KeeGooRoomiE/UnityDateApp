using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{

    public GameObject[] currentCard;
    public GameObject reactionPanel;
    public GameObject buttonPanel;
    private bool isSelection;
    public int cardCounter;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (isSelection)
        {
            reactionPanel.SetActive(true);
            buttonPanel.SetActive(false);
        } else
        {
            reactionPanel.SetActive(false);
            buttonPanel.SetActive(true);
        }

        if (cardCounter > 0)
        {
            isSelection = true;
        }
        else
        {
            isSelection = false;
        }
    }

    public void SetReaction(bool positive)
    {
        currentCard[cardCounter - 1].GetComponent<CardBehaviour>().SetAccepted(positive);
        currentCard[cardCounter - 1].GetComponent<CardBehaviour>().SetState(2);
        cardCounter -= 1;
        Debug.Log("Reaction implemented to "+positive);
    }
}
