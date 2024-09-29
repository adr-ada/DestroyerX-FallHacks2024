using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageController : MonoBehaviour
{
    public int health = 3;

    public GameObject circle;
    public GameObject gm;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("yes");
        circle.SetActive(false);
        gm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "SmallAsteroid")
        {
            Debug.Log("impact with " + col.gameObject.name);
            TakeDamage(1);
            Destroy(col.gameObject);
        }
        else if(col.gameObject.tag == "BigAsteroid")
        {
            circle.SetActive(true);
            Instantiate(circle, transform.position, transform.rotation);
            gm.SetActive(true);
            Destroy(gameObject);
            Destroy(circle);
            

        }
    }
}