using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.D))
	    {
	        float bb = GameObject.Find("GameObject").GetComponent<jingtaishuju>().get();
	        Debug.Log("bb" + bb);
            Debug.Log(GameObject.Find("www"));
	        Debug.Log(GameObject.Find("www").GetComponent<jingtaishuju>());
            float ss = GameObject.Find("www").GetComponent<jingtaishuju>().get();
	        Debug.Log("ss"+ss);
	        
            //Debug.Log(jingtaishuju.shuju1);
	    }
	    if (Input.GetKeyDown(KeyCode.I))
	    {
	        GameObject.Find("GameObject").GetComponent<jingtaishuju>().set(15);
        }

	}
}
