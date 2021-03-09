using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrow;
    public float launchForce;
    public Transform initPoint; 

    // Update is called once per frame
    void Update()
    {
        Vector2 bowPos = transform.position;
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = mousPos - bowPos;
        transform.right = dir;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject newArrow = Instantiate(arrow, initPoint.position, initPoint.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }
}
