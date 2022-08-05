using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCycle : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI status;
    [SerializeField] TextMeshProUGUI maxScore;


    // Start is called before the first frame update
    void Start()
    {
        status.rectTransform.sizeDelta = new Vector2(Screen.width, 100);
        
        int _maxScore = SaveHandler.sh_LoadMaxScore();
		Debug.Log("ms " + _maxScore);
		maxScore.text = _maxScore.ToString();
		ballCollider.maxScore = _maxScore;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Save high score before game exit    
	private void OnApplicationQuit() {
		Debug.Log("Saving game data . . .");
		SaveHandler.sh_SaveMaxScore(ballCollider.maxScore);
	}
}
