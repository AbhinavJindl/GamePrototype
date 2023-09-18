using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public Transform bulletSpawnPoint;   // The point from which bullets will be spawned (likely the end of the scope).
    public GameObject bulletPrefab;      // Drag your bullet prefab here.

    void Update()
    {
        if (GameManager.Instance.isOver)
            return;
        if (Input.GetButtonDown("Fire1")) // Fire1 is usually the left mouse button.
        {
            if (BulletCountManager.instance.BulletsLeft())
            {
                BulletCountManager.instance.ShootBullet();
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
