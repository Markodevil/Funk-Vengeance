using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public float rotationSpeed = 1;
    public float rotationTimer = 5;
    public float time;

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
        if(time > 5)
        {
            time = 0;
        }
    }
}
