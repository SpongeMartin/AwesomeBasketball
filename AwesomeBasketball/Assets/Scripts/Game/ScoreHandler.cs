using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler {

    private int score;
    private int maxScore;

    public ScoreHandler() {
        this.score = 0;
        this.maxScore = SaveHandler.sh_LoadMaxScore();
    }

       public int IncrementCurrentScore() {
        this.score += 1;
        return this.score;
    }

    public int GetCurrentScore() {
        return this.score;
    }

    public int GetMaxScore() {
        return this.maxScore;
    }

    public int SetCurrentScore(int a_score) {
        this.score = a_score;
        return this.score;
    }

    public int SetMaxScore(int a_maxScore) {
        this.maxScore = a_maxScore;
        return this.maxScore;
    }

    public bool HasUpdatedMaxScore() {
        if(this.GetMaxScore() > this.GetCurrentScore()) {
            return false;
        }

        this.SetMaxScore(GameCycle.scoreHandler.GetCurrentScore());
        return true;
    }
}
