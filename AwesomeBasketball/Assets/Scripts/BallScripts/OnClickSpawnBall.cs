using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    public moveBall other;
    public void Throw(){
        GameObject ball = GameObject.Find("ball");
        GameObject ballIndicator = GameObject.Find("BallIndicator");
        ball.transform.position = ballIndicator.transform.position;
        ball.transform.rotation = ballIndicator.transform.rotation;
        Rigidbody rigid = ball.GetComponent<Rigidbody>();
        rigid.isKinematic = true;
        rigid.isKinematic = false;
        Debug.Log(ballIndicator.transform.position);
    }
}