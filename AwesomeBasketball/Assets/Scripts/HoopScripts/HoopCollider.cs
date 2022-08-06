using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="ball"){
            MoveBall.HoopCollision = true;
        }
    }
}
