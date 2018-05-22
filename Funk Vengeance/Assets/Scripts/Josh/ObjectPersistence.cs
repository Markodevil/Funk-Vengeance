using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPersistence : MonoBehaviour {

    // On Awake
	void Awake ()
    {
        // Prevent the object from being deleted upon a scene being loaded
        DontDestroyOnLoad(gameObject);
   
        // Store a duplicate of the object into a variable if it exists
        GameObject duplicate = GameObject.Find(gameObject.name);

        // If said variable exists, then delete it
        if (duplicate != gameObject)
        {
            DestroyImmediate(duplicate);
            Debug.Log("Destroying Duplicate.");
        }
        else
        {
            Debug.Log("No Duplicates exist.");
        }
    }	
}
