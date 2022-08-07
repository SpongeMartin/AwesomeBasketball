using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomAnimation : StateMachineBehaviour
{
    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
        int num = Random.Range(0,9);
        animator.SetInteger("idAnimation", num);
        Debug.Log(num);
    }
}
