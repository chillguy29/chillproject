using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform[] waypointArray;
    [SerializeField] private float moveSpeed = 4f;
    private int life = 3;
    private int currentWaypointIndex = 0;
    /* private void Update()
     {
         if (Vector3.Distance(transform.position, waypointArray[currentWaypointIndex].position) < 0.1f)
         {
             currentWaypointIndex++;
             if (currentWaypointIndex >= waypointArray.Length)
             {
                 currentWaypointIndex = 0;
             }
         }
         transform.position = Vector3.MoveTowards(transform.position, waypointArray[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
     }
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Bullet>(out Bullet bullet) && life<0 )
        {
            life--;
        }
    }

    private void OnDestroy()
    {
        Destroy(gameObject);
    }
}
