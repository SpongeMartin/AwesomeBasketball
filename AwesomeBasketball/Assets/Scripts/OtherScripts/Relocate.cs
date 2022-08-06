using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Relocate : MonoBehaviour
{
    public void LoadScene(string sceneName){

        // Save game data before relocating
        SaveHandler.sh_SaveMaxScore(GameCycle.scoreHandler.GetMaxScore());


        SceneManager.LoadScene(sceneName);
    }
}
