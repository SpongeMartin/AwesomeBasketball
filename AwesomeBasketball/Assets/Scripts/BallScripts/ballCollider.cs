using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="ball"){
            ScoreText.score += 1;
        }
        //Debug.Log("Object entered the trigger");
    }
    
    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Object is inside the trigger");
    }
    
    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Object exited the trigger");
    }
}
