using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Add a public float variable to control how fast the obstacle moves across the screen.
    public float speed = 10.0f;
    // Add a public float variable to control how far the object should go before being destroyed offscreen.
    public float distance = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the obstacle to the left at a constant rate.

        // Make sure this calculation is frame rate independent (hint: use TIme.deltaTime).
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        // If the obstacle is offscreen to the left, destroy this GameObject (hint: use Destroy(gameObject)).
        if(transform.position.x < distance)
        {
            Destroy(gameObject);
        }
    }
}
