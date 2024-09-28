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
    }

    // Update is called once per frame
    void Update()
    {
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        body.velocity = new Vector2(0, speedY);
    }
}
