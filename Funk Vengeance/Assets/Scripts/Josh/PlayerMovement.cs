using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    [Tooltip("Player Movement speed.")]
    public float movementSpeed;
    void Start()
    {
        gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        // Move upwards
        if (Input.GetKey("w"))
        {
            gameObject.transform.position += new Vector3(0.0f, 0.0f, movementSpeed);
        }
        // Move downwards
        if (Input.GetKey("s"))
        {
            gameObject.transform.position += new Vector3(0.0f, 0.0f, -movementSpeed);
        }
        // Move leftwards
        if (Input.GetKey("a"))
        {
            gameObject.transform.position += new Vector3(-movementSpeed, 0.0f, 0.0f);
        }
        // Move rightwards
        if (Input.GetKey("d"))
        {
            gameObject.transform.position += new Vector3(movementSpeed, 0.0f, 0.0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // If colliding with an Enemy
        if (collision.collider.tag == "Enemy")
        {

        }
        // If colliding with the Target
        if (collision.collider.tag == "Target")
        {

        }
        // If colliding with the Door
        if (collision.collider.tag == "Door")
        {

        }
        // If colliding with a Powerup
        if (collision.collider.tag == "Powerup")
        {

        }
    }
}
