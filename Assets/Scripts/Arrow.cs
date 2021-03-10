using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference: 2D Bow and Arrow Tutorial - Blackthornprod
// https://www.youtube.com/watch?v=tNwLaGUJTK4&t=499s

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float angle = calcAngle(rb.velocity);
        // Rotates the arrow based on the value returned by calcAngle 
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
    }

    /*
     * Method to calculate the angle in which the arrow should rotate at to follow an arc 
     * Param: vel - velocity of the arrow 
     * Return: angle - the angle the arrow should rotate at to follow an arc
     */
    float calcAngle(Vector2 vel)
    {
        // Atan2 calculates angle=tan(y/x)
        // Angle = angle between x-axis and 2D vector starting at 0 and finishing at (x,y)
        // Rad2Deg converts from radians to degrees 
        // Reference: https://docs.unity3d.com/ScriptReference/Mathf.Atan2.html
        float angle = Mathf.Atan2(vel.y, vel.x) * Mathf.Rad2Deg;
        return angle;
    }
}
