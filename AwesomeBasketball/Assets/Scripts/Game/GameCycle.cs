using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCycle : MonoBehaviour
{

    public static ScoreHandler scoreHandler;

    [SerializeField] TextMeshProUGUI maxScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreHandler = new ScoreHandler();
        maxScoreText.text = scoreHandler.GetMaxScore().ToString();

        // int _maxScore =-1;
		// Debug.Log("ms " + _maxScore);
		// maxScore.text = _maxScore.ToString();
		// ballCollider.setMaxScore(_maxScore);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Save high score before game exit    
	private void OnApplicationQuit() {
		SaveHandler.sh_SaveMaxScore(scoreHandler.GetMaxScore());
	}
}
