using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBehaviour : MonoBehaviour
{
    private Animation anim;
    public float startDelay;
    private int state;
    public bool isAccepted;
    private bool isReacted = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        state = 0;
        StartCoroutine(CardAppear(startDelay));
    }

    IEnumerator CardAppear(float delay)
    {
        yield return new WaitForSeconds(delay);
        anim.Play("Appear", PlayMode.StopAll);
        state = 1;
        var app = GameObject.FindGameObjectWithTag("AppScreen");
        var appCount = app.GetComponent<AppController>().cardCounter;
        app.GetComponent<AppController>().currentCard[appCount] = gameObject;
        app.GetComponent<AppController>().cardCounter++;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isReacted)
        { 
            if (state == 2)
            {
                if (isAccepted == true)
                {
                    anim.Play("RightMove", PlayMode.StopAll);
                    isReacted = true;
                }
                else
                {
                    anim.Play("LeftMove", PlayMode.StopAll);
                    isReacted = true;
                }
            }
        }
    }

    public void SetAccepted(bool value)
    {
        isAccepted = value;
    }

    public void SetState(int value)
    {
        state = value;

        //0 - init
        //1 - placed, idle
        //2 - moved
    }
}
