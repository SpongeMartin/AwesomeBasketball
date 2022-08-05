using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool correctColor=false;
    MeshRenderer ball;
    MeshRenderer ballIndicator;
    public Material classic;
    public Material pink;
    public Material green;
    public Material red;
    public Material blue;
    public Material purple;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!correctColor)
        {
            ball = GameObject.Find("ball").GetComponent<MeshRenderer>();
            ballIndicator = GameObject.Find("BallIndicator").GetComponent<MeshRenderer>();
            switch (BallSelect.ballColor){
                case "Classic":
                    ball.material = classic;
                    ballIndicator.material = classic;
                    break;
                case "Pink":
                    ball.material = pink;
                    ballIndicator.material = pink;
                    break;
                case "Green":
                    ball.material = green;
                    ballIndicator.material = green;
                    break;
                case "Red":
                    ball.material = red;
                    ballIndicator.material = red;
                    break;
                case "Blue":
                    ball.material = blue;
                    ballIndicator.material = blue;
                    break;
                case "Purple":
                    ball.material = purple;
                    ballIndicator.material = purple;
                    break;
                default:
                    ball.material = classic;
                    ballIndicator.material = classic;
                    break;
            }
            correctColor = true;
        }
        
    }
}
