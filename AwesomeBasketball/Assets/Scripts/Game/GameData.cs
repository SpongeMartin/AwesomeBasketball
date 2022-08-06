using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData {
    public static GameData defaultData = new GameData(0, "Classic");
    
    public int maxScore;
    public string ballColor;

    public GameData(int ca_score, string ca_ballColor) {
        this.maxScore = ca_score;
        this.ballColor = ca_ballColor;
    }
}
