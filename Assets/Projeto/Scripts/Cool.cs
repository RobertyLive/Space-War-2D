using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cool : MonoBehaviour
{
    [Header("Time To Destroy")]
    public float timeToDestroy;


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject, timeToDestroy);
        }
    }
}
