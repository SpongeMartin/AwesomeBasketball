using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class BallHandler {
    private string ballSkin;
    
    public BallHandler(string ca_ballSkin) {
        ballSkin = ca_ballSkin;
        GameObject checkmark = GameObject.Find("CheckMarkImage");
        if(checkmark != null) {
            checkmark.transform.position = GameObject.Find(ca_ballSkin+"BasketballImage").transform.position;
        }
    }

    public void ChangeBallSkin(string a_skin) {
        this.ballSkin = a_skin;
        GameObject.Find("CheckMarkImage").transform.position = GameObject.Find(a_skin+"BasketballImage").transform.position;
        Game.skinChanged = false;
    }

    public string GetBallSkin() {
        return this.ballSkin;
    }
}
