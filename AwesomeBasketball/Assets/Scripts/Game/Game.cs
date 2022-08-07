using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public static ScoreHandler scoreHandler;
    public static BallHandler ballHandler;
    public static GameData data;
    public static bool skinChanged = false;
    [SerializeField] GameObject _ball;
    [SerializeField] GameObject _ballIndicator;

    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    public static void initialize() {
        // Loads saved data
        data = SaveHandler.sh_LoadGameData();

        // Initializes the score handler
        scoreHandler = new ScoreHandler(data.maxScore);
        scoreHandler.SetMaxScoreText(scoreHandler.GetMaxScore().ToString());

        // Loads ball material data
        Debug.Log("Loading ball color " + data.ballColor);
        ballHandler = new BallHandler(data.ballColor);
    }

    void Update() {
        //GameObject _ball = GameObject.Find("Ball");
        //GameObject _ballIndicator = GameObject.Find("BallIndicator");
        if(!skinChanged && _ball != null && _ballIndicator != null) {
            Debug.Log("Here");
            MeshRenderer _ballMeshRenderer = _ball.GetComponent<MeshRenderer>();
            MeshRenderer _ballIndicatorMeshRenderer = _ballIndicator.GetComponent<MeshRenderer>();
            
            string _skinName = ballHandler.GetBallSkin() + "Basketball";
            Material _material = Resources.Load("Materials/BasketballTextures/" + _skinName, typeof(Material)) as Material;

            _ballMeshRenderer.material = _material;
            _ballIndicatorMeshRenderer.material = _material;
 
            skinChanged = true;
        }
    }

    // Save high score before game exit    
	private void OnApplicationQuit() {
		SaveHandler.sh_SaveGameData();
	}
}
