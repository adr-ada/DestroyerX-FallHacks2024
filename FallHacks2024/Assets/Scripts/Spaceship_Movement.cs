using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship_Movement : MonoBehaviour
{
    Rigidbody2D body;
    public float moveSpeed;
    public float minY = -4.5f;  // Minimum Y position (adjust based on your game area)
    public float maxY = 4.5f;   // Maximum Y position (adjust based on your game area)
    float speedY;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the vertical input for the spaceship (up/down arrow keys or joystick)
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;

        // Calculate the new position based on the current position and speed
        float newYPosition = transform.position.y + speedY * Time.deltaTime;

        // Clamp the Y position between minY and maxY limits
        newYPosition = Mathf.Clamp(newYPosition, minY, maxY);

        // Apply the clamped Y position to the Rigidbody2D's velocity (keep X as zero)
        body.velocity = new Vector2(0, (newYPosition - transform.position.y) / Time.deltaTime);
    }
}
