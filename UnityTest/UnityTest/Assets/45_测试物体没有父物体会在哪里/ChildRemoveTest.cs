using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRemoveTest : MonoBehaviour
{

    public Transform child;
	// Use this for initialization
	void Start () {
		
	}
	
	// 没有父物体时，在Hierarchy的根目录
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        child.parent = null;
	    }
        print(child.parent);
	}
}
