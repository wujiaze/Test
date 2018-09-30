using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2Static : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(StaticTest.obj);
        Debug.Log(StaticTest.value);
        Debug.Log(StaticTest.value3);
        //Debug.Log(StaticTest.instance.value2);
        
	}
}
