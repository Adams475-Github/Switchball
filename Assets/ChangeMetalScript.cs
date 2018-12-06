using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMetalScript : MonoBehaviour {

    public GameObject player;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = player.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
       
	}

    private void OnTriggerEnter(Collider other)
    {

        rb.mass = 0.1f;
        Debug.Log("jeff");
    }
}
