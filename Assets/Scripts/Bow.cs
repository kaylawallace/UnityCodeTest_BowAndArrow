using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference: 2D Bow and Arrow Tutorial - Blackthornprod
// https://www.youtube.com/watch?v=tNwLaGUJTK4&t=499s

public class Bow : MonoBehaviour
{
    public GameObject arrow;
    public float launchForce;
    public Transform initPoint; 

    // Update is called once per frame
    void Update()
    {
        Vector2 bowPos = transform.position;
        // Convert mouse position to coords world space 
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = mousPos - bowPos;
        transform.right = dir;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    /*
     * Method to instantiate a new arrow at a position at the end of the bow (initPoint) and shoot it in correct direction
     */
    void Shoot()
    {
        GameObject newArrow = Instantiate(arrow, initPoint.position, initPoint.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }
}
