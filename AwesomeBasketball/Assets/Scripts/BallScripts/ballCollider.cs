using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;

public class ballCollider : MonoBehaviour
{
    public static int score = 0;
    public static int maxScore = 0;
    public static bool missed = true;

    [SerializeField] TextMeshProUGUI currentScore;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="ball"){
<<<<<<< HEAD
            missed = false;
            score += 1;
            currentScore.text = score.ToString();
          }
=======
            ScoreText.score += 1;
        }
>>>>>>> c4dae430a02baaa6656965758bcdc4a0d7bc8a8c
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
