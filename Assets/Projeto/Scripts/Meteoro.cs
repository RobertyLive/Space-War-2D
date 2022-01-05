using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{

    private void Update() {
        if(transform.position.x > 13 || transform.position.x < -13)
        {
            Destroy(gameObject);
        }

        if(transform.position.y > 10 || transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
