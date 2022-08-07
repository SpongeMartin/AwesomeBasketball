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
            anim.SetInteger("hoopsCount", 0);
        }else if(Game.scoreHandler.GetCurrentScore() == 1){
            anim.SetInteger("hoopsCount", 1);
        }else if(Game.scoreHandler.GetCurrentScore() == 2){
            anim.SetInteger("hoopsCount", 2);
        }else if(Game.scoreHandler.GetCurrentScore() == 3){
            anim.SetInteger("hoopsCount", 3);
        }else if(Game.scoreHandler.GetCurrentScore() == 4){
            anim.SetInteger("hoopsCount", 4);
        }
    }
}
