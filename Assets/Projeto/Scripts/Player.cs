using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerController
{
   
    public Gun gun;

    private void Start() {
        gun = GetComponent<Gun>();
    }

    void Touch()
    {
        Vector2 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if(Input.GetMouseButtonDown(0))
        {
            if(camPos.x < Screen.width /2)
            {
                if(camPos.x / 2 > 0)
                {
                    transform.Rotate(transform.rotation.x, transform.rotation.y, -speedToRotation * Time.deltaTime);
                }
                else
                {
                    transform.Rotate(transform.rotation.x, transform.rotation.y, speedToRotation * Time.deltaTime);
                }
            }
        }

        if(Input.GetMouseButton(1))
        {
            if(camPos.x > Screen.width /2)
            {
                gun.Shoot();
                Move();
            }
        }
    }
}
