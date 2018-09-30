using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBase : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("d");
        transform.localScale = new Vector3(10, 10, 10);
    }
    private void OnEnable()
    {
        //transform.localScale = new Vector3(10, 10, 10);
    }
    void Start () {
        //transform.localScale = new Vector3(10, 10, 10);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
