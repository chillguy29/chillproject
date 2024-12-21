using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 30f;
    [SerializeField] private int life = 3;
    private Vector2 direction;

    public void Shoot(Vector2 direction)
    {
        this.direction = direction;
        rb.velocity = direction * speed; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        life--;
        if (life < 0)
        {
            Destroy(gameObject);
            return;
        }      

        var firstContact = collision.contacts[0];
        Vector2 newVelocity = Vector2.Reflect(direction.normalized, firstContact.normal);
        Shoot(newVelocity.normalized);
    }

    

}
