using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour {

    public GameObject sphere;
    //0 forward, 1 right, 2 back, 3 left
    public int currentDirection;
    Vector3 spherePos;
    
	// Use this for initialization
	void Start () {
        currentDirection = 0;
	}
	
	// Update is called once per frame
	void Update () {

        getInput();

        
        if (currentDirection.Equals(0))
        {
            
            spherePos = new Vector3(sphere.transform.position.x, sphere.transform.position.y+2, sphere.transform.position.z-3);

            transform.rotation = Quaternion.Euler(20, 0, 0);
            transform.position = spherePos;
        } else if (currentDirection.Equals(1))
        {
            
            spherePos = new Vector3(sphere.transform.position.x - 3, sphere.transform.position.y + 2, sphere.transform.position.z);

            transform.rotation = Quaternion.Euler(20, 90, 0);
            transform.position = spherePos;
        } else if (currentDirection.Equals(2))
        {
            
            spherePos = new Vector3(sphere.transform.position.x, sphere.transform.position.y + 2, sphere.transform.position.z + 3);

            transform.rotation = Quaternion.Euler(20, 180, 0);
            transform.position = spherePos;
        }
        else if (currentDirection.Equals(3))
        {
            
            spherePos = new Vector3(sphere.transform.position.x + 3, sphere.transform.position.y + 2, sphere.transform.position.z);

            transform.rotation = Quaternion.Euler(20, 270, 0);
            transform.position = spherePos;
        }



    }

    public void getInput()
    {
        if (Input.GetKeyDown("right"))
        {
            if(currentDirection + 1 > 3)
            {
                currentDirection = 0;
                return;
            }
            currentDirection++;
        }
        if (Input.GetKeyDown("left"))
        {
            if(currentDirection - 1 < 0)
            {
                currentDirection = 3;
                return;
            }
            currentDirection--;
        }
    }
}
