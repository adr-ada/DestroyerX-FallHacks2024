using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship_Movement : MonoBehaviour
{
    Rigidbody2D body;
    public float moveSpeed;
    float speedY;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;  // Ensure the z-axis is 0 for 2D

        // Calculate the direction from the bullet's position to the mouse position
        Vector2 direction = (mousePosition - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    {
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        body.velocity = new Vector2(0, speedY);
    }
}
