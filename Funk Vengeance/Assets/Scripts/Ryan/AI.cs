using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public bool MR_RED;
    public bool MR_BLUE;
    public bool MR_GREEN;
    public bool MR_YELLOW;

    [HideInInspector]
    public float rotationAmount = 90;
    public float rotationTimer;

    [SerializeField]
    private float time;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        //if (time > rotationTimer)
        //{
            transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
            time = 0;
        //}
    }
}
