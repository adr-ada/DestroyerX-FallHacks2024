using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageController : MonoBehaviour
{
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("yes");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "SmallAsteroid")
        {
            Debug.Log("impact with " + col.gameObject.name);
        }
    }
}
