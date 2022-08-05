using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSelect : MonoBehaviour
{
    public static string ballColor = "Classic";
    public void ChangeBall(string color){
        ballColor = color;
        SetColor.correctColor = false;
    }
}
