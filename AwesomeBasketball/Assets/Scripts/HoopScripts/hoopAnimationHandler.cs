using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoopAnimationHandler : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Game.scoreHandler.GetCurrentScore() == 0){
            anim.SetBool("backToStart", true);
        }
        if(Game.scoreHandler.GetCurrentScore() < 5){
            anim.speed = 0;
        }else if(Game.scoreHandler.GetCurrentScore() == 5){
            anim.speed = 1;
            anim.SetBool("backToStart", false);
        }else if(Game.scoreHandler.GetCurrentScore() == 10){
            anim.speed = 1.5f;
        }else if(Game.scoreHandler.GetCurrentScore() == 15){
            anim.speed = 2;
        }else if(Game.scoreHandler.GetCurrentScore() == 20){
            anim.speed = 2.5f;
        }else if(Game.scoreHandler.GetCurrentScore() == 25){
            anim.speed = 3;
        }
    }
}
