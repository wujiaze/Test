using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    StartCoroutine("Do");
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.D))
	    {
            StopAllCoroutines();
	    }
	}
    private IEnumerator Do()
    {
        while (true)
        {
            Debug.Log("B");
            yield return null;
        }
    }
}
