using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed, speedToRotation;

    private float control;

    public float maxX, maxY;

    private void Update()
    {
        control = Input.GetAxis("Vertical");
        Rotate();
        Teleport();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed * control);
    }

    private void Rotate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y, speedToRotation * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y, -speedToRotation * Time.deltaTime);
        }
    }

    private void Teleport()
    {
        if(transform.position.x > maxX)
        {
            transform.position = new Vector2(-maxX, transform.position.y);
        }
        else if(transform.position.x < -maxX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }

        if(transform.position.y > maxY)
        {
            transform.position = new Vector2(transform.position.x, -maxY);
        }
        else if(transform.position.y < -maxY)
        {
            transform.position = new Vector2(transform.position.x, maxY);
        }
    }
}
