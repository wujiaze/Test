using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atest : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        StartCoroutine("Do");
	    }
	    if (Input.GetKeyDown(KeyCode.B))
	    {
	        StopCoroutine("Do");
	    }
    }

    private IEnumerator Do()
    {
        while (true)
        {
            Debug.Log("A");
            yield return null;
        }
    }
}
