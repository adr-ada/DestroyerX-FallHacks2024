using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody2D component
        body = GetComponent<Rigidbody2D>();

        // Get the mouse position in the world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;  // Ensure the z-axis is 0 for 2D

        // Calculate the direction from the bullet's position to the mouse position
        Vector2 direction = (mousePosition - transform.position).normalized;

        // Set the velocity of the bullet towards the direction of the mouse click
        body.velocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the bullet after 3 seconds
        Destroy(gameObject, 3);
    }

        void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Contains("Asteroid"))
        {
            Destroy(gameObject);
        }
    }
}
