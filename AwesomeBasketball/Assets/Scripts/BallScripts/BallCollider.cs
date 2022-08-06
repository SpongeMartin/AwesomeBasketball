using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;

public class BallCollider : MonoBehaviour
{
    private static bool collided = false;

    [SerializeField] TextMeshProUGUI currentScore;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="ball"){
            GameCycle.scoreHandler.IncrementCurrentScore();
            currentScore.text = GameCycle.scoreHandler.GetCurrentScore().ToString();
            SetWasCollided(true);  
        }
    }
    
    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Object is inside the trigger");
    }
    
    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Object exited the trigger");
    }

    public static bool SetWasCollided(bool a_flag) {
        collided = a_flag;
        return collided;
    }

    public static bool GetWasCollided() {
        return collided;
    }
}
