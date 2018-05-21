using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    [Tooltip("Player Movement speed.")]
    public float movementSpeed;

    //[SerializeField]
    //[Tooltip("Player Rotation speed.")]
    //public float rotationSpeed;

    [SerializeField]
    [Tooltip("Canvas to be enabled upon leaving the area.")]
    public Canvas LeaveCanvas;

    void Start()
    {
        // Set the player's position
        gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        // Get the LeaveCanvas's Canvas component
        LeaveCanvas.GetComponent<Canvas>();
    }

    void Update()
    {
        // Move upwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * movementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -movementSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -movementSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * movementSpeed;
        }

        // Rotate leftwards
        //if (Input.GetKey("left"))
        //{
        //    gameObject.transform.Rotate(0, rotationSpeed, 0);
        //}
        //// Rotate rightwards
        //if (Input.GetKey("right"))
        //{
        //    gameObject.transform.Rotate(0, -rotationSpeed, 0);
        //}
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
            // Enable canvas to display UI
            LeaveCanvas.gameObject.SetActive(true);
        }

        // If colliding with a Powerup
        if (collision.collider.tag == "PowerUp")
        {

        }
        // If colliding with a Weapon
        if (collision.collider.tag == "Weapon")
        {

        }
    }
}
