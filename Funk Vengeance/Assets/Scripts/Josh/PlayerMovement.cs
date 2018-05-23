using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GM;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    [Tooltip("Player Movement speed.")]
    public float movementSpeed;
    public bool canMove = true;

<<<<<<< .mine
    [SerializeField]
    [Tooltip("Canvas UIs.")]
    //public GameObject canvasUIs;
||||||| .r53
    [SerializeField]
    [Tooltip("Canvas UIs.")]
    public GameObject canvasUIs;
=======
    //[SerializeField]
    //[Tooltip("Canvas UIs.")]
    //public GameObject canvasUIs;
>>>>>>> .r55

<<<<<<< .mine
    public GameManager GM;
    //private UIManager uim;
||||||| .r53
    private UIManager uim;
=======
    //private UIManager uim;
>>>>>>> .r55

    void Start()
    {
        // Set the player's position
        //gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

<<<<<<< .mine
       // uim = canvasUIs.GetComponent<UIManager>();
||||||| .r53
        uim = canvasUIs.GetComponent<UIManager>();
=======
        //uim = canvasUIs.GetComponent<UIManager>();
>>>>>>> .r55
    }

    void Update()
    {
        if (GM.hasWon == true)
        {
            movementSpeed = 0;
        }
        // Move upwards
        if (Input.GetKey(KeyCode.W) && canMove == true)
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && canMove == true)
        {
            transform.position += transform.forward * -movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && canMove == true)
        {
            transform.position += transform.right * -movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && canMove == true)
        {
            transform.position += transform.right * movementSpeed* Time.deltaTime;
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    // If colliding with an Enemy
    //    if (collision.collider.tag == "Enemy")
    //    {

    //    }
    //    // If colliding with the Target
    //    if (collision.collider.tag == "Target")
    //    {

    //    }

    //    // If colliding with the Door
    //    if (collision.collider.tag == "Door")
    //    {
    //        // Enable Victory canvas
    //        uim.VictoryCanvas.gameObject.SetActive(true);
    //        // Set timescale to 0 to pause the scene
    //        uim.isPaused = false;
    //    }

    //    // If colliding with a Powerup
    //    if (collision.collider.tag == "PowerUp")
    //    {

    //    }
    //    // If colliding with a Weapon
    //    if (collision.collider.tag == "Weapon")
    //    {

    //    }
    //}
}
