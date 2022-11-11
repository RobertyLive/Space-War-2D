using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Speed of Bullet")]
    public float speedBullet;
    [Header("References do shooter")]
    public GameObject prefabBullet;
    public Transform GunShooter;

    private GameObject _bullet;
    private Rigidbody2D _rb;
    

    public void Update()
    {
        // if(Input.GetButtonDown("Fire1"))
        // {
        //    Shoot();       
        // }
    }

    public void Shoot()
    {
        _bullet = Instantiate(prefabBullet, GunShooter.position, GunShooter.rotation);

        _rb = _bullet.GetComponent<Rigidbody2D>();

        _rb.AddForce(GunShooter.up * speedBullet, ForceMode2D.Impulse);

        Destroy(_bullet, 0.5f);
    }
}
