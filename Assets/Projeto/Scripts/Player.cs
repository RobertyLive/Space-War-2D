using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public Gun gun;
    public float speedToRotation;
    public float speed;
    public bool isRot;

    
    public float maxX, maxY;

    private void Start() {
        gun = GetComponent<Gun>();
    }

    private void Update() {
        Touch();
        Teleport();
        
    }

    void Touch()
    {
        gun.Shoot();

        if(Input.GetMouseButton(0) && isRot)
        {
            if(Input.mousePosition.x > Screen.height / 2)
            {
                transform.Rotate(transform.rotation.x, transform.rotation.y, -speedToRotation * Time.deltaTime);
            }
            else
            {
                transform.Rotate(transform.rotation.x, transform.rotation.y, speedToRotation * Time.deltaTime);
            }
        }

        if(Input.GetMouseButton(1))
        {
            isRot = false;
            Move();    
        }
        if(Input.GetMouseButtonUp(1))
        {
            isRot = true;
        }
    }

    void Move()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
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
