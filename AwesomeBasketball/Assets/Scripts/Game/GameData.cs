using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData {
    public int maxScore;
    
    public GameData(int mscore) {
        this.maxScore = mscore;
    }
}
