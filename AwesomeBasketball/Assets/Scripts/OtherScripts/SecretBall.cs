using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretBall : MonoBehaviour
{
    //[SerializeField] GameObject PurpleBall;
    [SerializeField] GameObject PurpleParticleSystem;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="Ball"){
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Animator>().enabled = false;
            GetComponent<SphereCollider>().enabled = false;
            PurpleParticleSystem.GetComponent<ParticleSystem>().enableEmission = false;
        }
    }
}
