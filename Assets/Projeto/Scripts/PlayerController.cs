using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private float control;

    private void Update()
    {
        control = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed * control);
    }

    private void Rotate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y, speed);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y, -speed);
        }
    }
}
