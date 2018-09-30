using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gampppo : MonoBehaviour
{

    public GameObject target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Debug.Log(target.transform.localPosition);
	    if (Input.GetKeyDown(KeyCode.B))
	    {
	        target.SetActive(true);
	    }
    }
}
