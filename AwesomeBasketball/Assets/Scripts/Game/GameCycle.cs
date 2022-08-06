using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCycle : MonoBehaviour
{
    public static ScoreHandler scoreHandler;

    // Start is called before the first frame update
    void Start()
    {
        scoreHandler = new ScoreHandler();
        scoreHandler.SetMaxScoreText(scoreHandler.GetMaxScore().ToString());
    }

    // Save high score before game exit    
	private void OnApplicationQuit() {
		SaveHandler.sh_SaveMaxScore(scoreHandler.GetMaxScore());
	}
}
