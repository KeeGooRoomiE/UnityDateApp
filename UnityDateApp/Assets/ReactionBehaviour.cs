using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionBehaviour : MonoBehaviour
{

    public AppController app;
    // Start is called before the first frame update
    public void ReactPositive()
    {
        app.SetReaction(true);
        Debug.Log("button reaction positive reacted");
    }

    public void ReactNegative()
    {
        app.SetReaction(false);
        Debug.Log("button reaction negative reacted");
    }
}
