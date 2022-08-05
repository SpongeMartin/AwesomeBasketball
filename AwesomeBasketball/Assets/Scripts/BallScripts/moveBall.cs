using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public static bool HoopCollision = false;
    bool firstUpdate = false;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(ThrowBegin){
            if (!firstUpdate){
                firstUpdate = true;
                RotateSwipeDirection();
            }
            Animation += Time.deltaTime;
            if(Animation<=1.5f && !HoopCollision){
                currentPosition = GameObject.Find("ARCamera").transform.position;
                hoop = GameObject.Find("hoop");
                CreateParabolaAnimation();
            }
            if(Animation>1.5f || HoopCollision){
                transform.position = transform.position;
                if(!HoopCollision){
                    Vector3 AfterAnimationDirection = new Vector3(0,0,7);
                    GetComponent<Rigidbody>().AddRelativeForce(AfterAnimationDirection);
                }
            }
            if(Animation>4f){
                ThrowBegin = false;
                Animation = 0f;
                GameObject.Find("BallIndicator").GetComponent<MeshRenderer>().enabled = true;
                GetComponent<MeshRenderer>().enabled = false;
                HoopCollision = false;
                firstUpdate = false;
            }
        }
    }
    void CreateParabolaAnimation(){
        //Requires minor tweaks
        Vector3 hoopPosition = hoop.transform.position;
        float hoopBallDistance = Vector2.Distance(new Vector2(hoopPosition.x,hoopPosition.z),new Vector2(currentPosition.x,currentPosition.z));
        float radianRotation = (float)(Math.PI / 180) * CameraRotation;
        float xCoordinate = (float)(hoopBallDistance*Math.Sin(radianRotation))+currentPosition.x;
        float zCoordinate = (float)(hoopBallDistance*Math.Cos(radianRotation))+currentPosition.z;
        Vector3 facingOffset = new Vector3(xCoordinate,0,zCoordinate) - swipeDirection/750;
        rigid.isKinematic = false;
        transform.position = MathParabola.Parabola(currentPosition,facingOffset+new Vector3(0,0.3f,-0.1f),0.7f,Animation/1.5f);
    }
    void RotateSwipeDirection(){
        swipeDirection = Quaternion.Euler(0, CameraRotation, 0) * swipeDirection;
    }
}
