using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class moveBall : MonoBehaviour
{

    protected float Animation;
    Rigidbody rigid;
    public static bool ThrowBegin = false;
    public static Vector3 swipeDirection;
    Vector3 currentPosition;
    Vector3 endPosition;
    public static float CameraRotation;
    GameObject hoop;

    [SerializeField] TextMeshProUGUI status;
    [SerializeField] TextMeshProUGUI currentScore;
    [SerializeField] TextMeshProUGUI maxScore;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(ThrowBegin){
            Animation += Time.deltaTime;
            if(Animation<=2f){
                currentPosition = GameObject.Find("ARCamera").transform.position;
                hoop = GameObject.Find("hoop");
                CreateParabolaAnimation();
            }
            if(Animation>2f){
                transform.position = transform.position;
                currentPosition -= endPosition;
                //Change addforce plox!!!!!!!!!!!!!!!!
                GetComponent<Rigidbody>().AddForce(new Vector3(0,0,4));
            }
            if(Animation>4f){

                // Updating max score if current score if higher
                if (ballCollider.score > ballCollider.maxScore) {
                    ballCollider.maxScore = ballCollider.score;
                    maxScore.text = ballCollider.maxScore.ToString();
                }

                // Code to be executed when you miss
                if (ballCollider.missed) {
                    status.text = "\n Your max score is: " + ballCollider.maxScore;

                    ballCollider.score = 0;
                    currentScore.text = "0";
                }

                // Resets the missed flag
                ballCollider.missed = true;

                ThrowBegin = false;
                Animation = 0f;
                GameObject.Find("BallIndicator").GetComponent<MeshRenderer>().enabled = true;
                GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
    void CreateParabolaAnimation(){
        //Requires minor tweaks
        Vector3 hoopPosition = hoop.transform.position;// + new Vector3(0,1.3f,0.20f);
        float hoopBallDistance = Vector2.Distance(new Vector2(hoopPosition.x,hoopPosition.z),new Vector2(currentPosition.x,currentPosition.z));
        float xCoordinate = (float)(hoopBallDistance*Math.Sin((Math.PI / 180) * CameraRotation))+currentPosition.x;
        float zCoordinate = (float)(hoopBallDistance*Math.Cos((Math.PI / 180) * CameraRotation))+currentPosition.z;
        Vector3 facingOffset = new Vector3(xCoordinate,0,zCoordinate) - swipeDirection/750;
        rigid.isKinematic = false;
        transform.position = MathParabola.Parabola(currentPosition,facingOffset+new Vector3(0,0.3f,-0.1f),1f,Animation/2f);
    }
}
