using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler {

    private TextMeshProUGUI currentScoreText;
    private TextMeshProUGUI maxScoreText;
    
    private int score;
    private int maxScore;

    public ScoreHandler() {
        this.score = 0;
        this.maxScore = SaveHandler.sh_LoadMaxScore();
        this.currentScoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        this.maxScoreText = GameObject.Find("MaxScoreText").GetComponent<TextMeshProUGUI>();
    }

       public int IncrementCurrentScore() {
        this.SetCurrentScore(this.GetCurrentScore() + 1);
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
        if(a_score > 0) {
            this.currentScoreText.text = a_score.ToString();
        }
        return this.score;
    }

    public int SetMaxScore(int a_maxScore) {
        this.maxScore = a_maxScore;
        maxScoreText.text = a_maxScore.ToString();
        return this.maxScore;
    }

    public bool UpdateMaxScore() {
        if(this.GetMaxScore() > this.GetCurrentScore()) {
            return false;
        }
        this.SetMaxScore(GameCycle.scoreHandler.GetCurrentScore());
        return true;
    }

    public void SetCurrentScoreText(string text) {
        this.currentScoreText.text = text;
    }

    public void SetMaxScoreText(string text) {
        this.maxScoreText.text = text;
    }
}
