using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingAnimEndBehaviour : StateMachineBehaviour
{
    public GameObject AppScene;
    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AppScene.SetActive(true);
    }
}
