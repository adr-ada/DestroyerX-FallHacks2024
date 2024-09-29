using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;  // Asteroid health
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Projectile")
        {
            health -= 1;
            if(health <= 0){
                Destroy(gameObject);
            }
        }
    }

}
