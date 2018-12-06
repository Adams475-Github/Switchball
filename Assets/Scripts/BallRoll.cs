using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoll : MonoBehaviour {

    public Rigidbody rb;
    public string direction = "north";
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("w"))
        {
            getDirection();

        }
	}

    void getDirection()
    {
        if (transform.rotation.x >= 0 && transform.rotation.x <= 90)
        {
            direction = "north";
        }
    }
}
