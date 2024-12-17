using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefabs;
    [SerializeField] Transform bulletSpawnPos;
    [SerializeField] private int maxAmmo = 3;
    private int currentAmmo;
    private Camera cam;
    Vector2 MousePos
    {
        get
        {
            Vector2 pos = cam.ScreenToWorldPoint(Input.mousePosition);
            return pos;
        }
    }

    private void Awake()
    {
        cam = Camera.main;
    }

    private void Start()
    {
        currentAmmo = maxAmmo;
    }

    private void Update()
    {   
        if (Input.GetMouseButtonDown(0))
        {
            if (currentAmmo > 0) {
                currentAmmo--;
                ShootBullet();
            }
            
        }
    }

    private void ShootBullet ()
    {
        Vector2 direction = MousePos - (Vector2)transform.position;
        Bullet bullet = Instantiate(bulletPrefabs, bulletSpawnPos.position, Quaternion.identity);
        bullet.Shoot(direction.normalized);
    }

}
