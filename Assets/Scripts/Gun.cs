using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefabs;
    [SerializeField] Transform bulletSpawnPos;

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

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 direction = MousePos - (Vector2)transform.position;
            Bullet bullet = Instantiate(bulletPrefabs, bulletSpawnPos.position, Quaternion.identity);
            bullet.Shoot(direction.normalized);
        }

    }
}
