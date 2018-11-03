using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *  SetActive(true),多次和一次是一样的，就是激活，然后就会执行 OnEnable ，就是加了个判断，所以不会多次调用 OnEnable
 */
public class CallBackTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    
    private void OnEnable()
    {
        print("OnEnable");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
