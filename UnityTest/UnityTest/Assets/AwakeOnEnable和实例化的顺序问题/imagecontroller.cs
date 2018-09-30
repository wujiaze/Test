using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagecontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject prafab;
    public Transform parent;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(prafab, Vector3.zero,Quaternion.identity, parent);
        }
	}
}
