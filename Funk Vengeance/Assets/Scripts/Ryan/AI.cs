using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public bool MR_RED;
    public bool MR_BLUE;
    public bool MR_GREEN;
    public bool MR_YELLOW;

    public float rotationSpeed = 1;
    public float rotationTimer = 5;
    [SerializeField]
    private float time;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if (time < rotationTimer)
        {
            transform.Rotate(Vector3.up * rotationSpeed, Space.World);
        }
        if(time > 10)
        {
            time = 0;
        }
    }
}
