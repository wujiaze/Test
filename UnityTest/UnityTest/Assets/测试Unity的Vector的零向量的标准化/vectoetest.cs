
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectoetest : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    Vector2 tempv2 = Vector3.zero;
	    Vector2 v2normal = tempv2.normalized;
        Debug.Log(v2normal);
	    float AngleRad = Vector2.Angle(new Vector2(10,0), Vector2.zero);
        Debug.Log(AngleRad);
	     Debug.Log(Vector3.Cross(Vector3.one, Vector3.zero));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
