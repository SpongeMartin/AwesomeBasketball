using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour {

	Vector2 startPos, endPos; // touch start position, touch end position, swipe direction
	float touchTimeStart, touchTimeFinish, timeInterval; // to calculate swipe time to sontrol throw force in Z direction

	Rigidbody rb;

	static bool begin=false;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		begin=true;
	}

	// Update is called once per frame
	void Update () {

		// if you touch the screen
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {

			// getting touch position and marking time when you touch the screen
			touchTimeStart = Time.time;
			startPos = Input.GetTouch (0).position;
		}

		if(begin){
		// if you release your finger
			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {

				// marking time when you release it
				touchTimeFinish = Time.time;

				// calculate swipe time interval 
				timeInterval = touchTimeFinish - touchTimeStart;

				// getting release finger position
				endPos = Input.GetTouch (0).position;

				// calculating swipe direction in 2D space
				
				moveBall.swipeDirection = new Vector3(startPos.x - endPos.x,0,0);

				GameObject ball = GameObject.Find("ball");
				GameObject ballIndicator = GameObject.Find("BallIndicator");
				GameObject arcamera = GameObject.Find("ARCamera");
				ball.transform.position = ballIndicator.transform.position;
				ball.transform.rotation = arcamera.transform.rotation;
				Rigidbody rigid = ball.GetComponent<Rigidbody>();
				rigid.isKinematic = true;
				rigid.isKinematic = false;
				ballIndicator.GetComponent<MeshRenderer>().enabled = false;
				ball.GetComponent<MeshRenderer>().enabled = true;
				moveBall.CameraRotation = CameraAngle(arcamera);
				moveBall.ThrowBegin = true;
			}
			float CameraAngle(GameObject arcamera){
				float angle = arcamera.transform.localEulerAngles.y;
				if(angle < 0){
					angle = 360+angle;
				}
				return angle;
			}
		}
			
	}
}
