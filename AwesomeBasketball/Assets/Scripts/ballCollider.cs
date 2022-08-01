using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="ball"){
            Debug.Log("You scored!");
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
