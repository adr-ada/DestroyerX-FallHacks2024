using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform shootingPosition;
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        // Left-click
        if(Input.GetMouseButtonDown(0)){
            Instantiate(bullet, shootingPosition.position, transform.rotation);
        }
    }
}
