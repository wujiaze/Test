using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTEst : MonoBehaviour
{

    public GameObject obj;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        obj.SetActive(true);
        }
	    if (Input.GetKeyDown(KeyCode.B))
	    {
	        obj.SetActive(false);
	    }
    }
}
