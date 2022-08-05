using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{

    float width;
    float height;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        width = Screen.width;
        height = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        if(score>0) GameObject.Find("ScoreText").GetComponent<TMP_Text>().text = score.ToString();
    }
}
