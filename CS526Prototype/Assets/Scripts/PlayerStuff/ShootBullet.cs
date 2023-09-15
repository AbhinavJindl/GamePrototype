using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public Transform bulletSpawnPoint;   // The point from which bullets will be spawned (likely the end of the scope).
    public GameObject bulletPrefab;      // Drag your bullet prefab here.
    private float bulletSpeed = 20.0f;    // Speed of the bullet.
    public int numAllowedBullets = 5;
    private int numBulletsShot = 0;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Fire1 is usually the left mouse button.
        {
            numBulletsShot += 1;
            if (numBulletsShot < numAllowedBullets)
            {
                Shoot();
            }
            
        }
    }

    void Shoot()
    {
        // Instantiate a new bullet.
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}
