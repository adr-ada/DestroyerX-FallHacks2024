using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;  // Reference to the asteroid prefab
    public float spawnRate = 1.0f;     // How often to spawn asteroids (in seconds)
    public float spawnOffset = 2.0f;   // Offset from the right side of the screen
    public float minSpeed = 2f;        // Minimum speed for the asteroids
    public float maxSpeed = 5f;        // Maximum speed for the asteroids
    public float minSize = 0.5f;       // Minimum size for the asteroids
    public float maxSize = 1.5f;       // Maximum size for the asteroids

    private Camera mainCamera;
    public int health;  // Asteroid health

    void Start()
    {

        // Get the main camera to calculate screen bounds
        mainCamera = Camera.main;

        // Start the coroutine that spawns asteroids periodically
        StartCoroutine(SpawnAsteroids());
    }

    IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            // Spawn an asteroid
            SpawnAsteroid();

            // Wait for the next spawn
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void SpawnAsteroid()
    {
        // Calculate the screen bounds based on the camera view
        Vector2 screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));

        // Set spawn position off-screen to the right
        Vector2 spawnPosition = new Vector2(screenBounds.x + spawnOffset, Random.Range(-screenBounds.y, screenBounds.y));

        // Instantiate the asteroid at the random off-screen position
        GameObject asteroid = Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);

        // Randomize the asteroid's size
        float randomSize = Random.Range(minSize, maxSize);
        asteroid.transform.localScale = new Vector3(randomSize, randomSize, 1f);

        // Get the Rigidbody2D component of the asteroid to apply physics
        Rigidbody2D rb = asteroid.GetComponent<Rigidbody2D>();

        // Set a direction for the asteroid to move (leftward or random direction)
        Vector2 randomDirection = new Vector2(-1, Random.Range(-0.5f, 0.5f)).normalized;  // Move left with some random Y component

        // Assign a random speed between minSpeed and maxSpeed
        float randomSpeed = Random.Range(minSpeed, maxSpeed);

        // Set the asteroid's velocity
        rb.velocity = randomDirection * randomSpeed;
        
        rb.angularVelocity = Random.Range(5,20);
    }

    void OnBecameInvisible() {
    Destroy(gameObject);
}

}
