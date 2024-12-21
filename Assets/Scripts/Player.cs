using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerVisual playerVisual;
    [SerializeField] private Gun gun;

    private void Update()
    {
        playerVisual.Flip();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            gun.Reload();
        }
    }

}
