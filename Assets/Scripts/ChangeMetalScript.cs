using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMetalScript : MonoBehaviour {

    public GameObject player;
    public Rigidbody rb;
    public Material mat;
    public Material playerMat;
   

	// Use this for initialization
	void Start () {
        rb = player.GetComponent<Rigidbody>();
        playerMat = player.GetComponent<Material>();
	}
	
	// Update is called once per frame
	void Update () {
		
       
	}

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<Renderer>().material = mat;
        player.GetComponent<Rigidbody>().mass = 1.5f;
        Debug.Log("jeff");
    }
}
