using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // The lifespan of the GameObject
    public float life = 1f;

    void Awake()
    {
        // Destroy the GameObject after its lifespan has elapsed
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object colliding has the tag "Bullet"
        if (collision.gameObject.CompareTag("bullet"))
        {
            // Destroy both the bullet and this GameObject (enemy)
            Destroy(collision.gameObject); // Destroy the bullet
            Destroy(gameObject); // Destroy the enemy
        }
    }
}
