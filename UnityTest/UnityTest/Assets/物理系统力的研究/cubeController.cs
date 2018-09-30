using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{

    public GameObject cube;
    private Rigidbody rb;

    void Start ()
	{
	    rb = cube.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    rb.AddForce(new Vector3(0, 100, 0));
    }
}
