using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SkinSelector : MonoBehaviour
{
    public void ChangeBallSkin(string a_ballSkin) {
        Game.ballHandler.ChangeBallSkin(a_ballSkin);
    }
}
