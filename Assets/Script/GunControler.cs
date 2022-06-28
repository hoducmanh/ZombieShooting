using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControler : MonoBehaviour
{
    public bool isFiring;
    public BulletControler bullet;
    public float bulletSpeed;
    public float timeBetweenShot;
    private float bulletTime;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        bulletTime -= Time.deltaTime;
        if (bulletTime <= 0)
        {
                bulletTime = timeBetweenShot;
                BulletControler newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletControler;
                newBullet.speed = bulletSpeed;
        }
    }     
}
