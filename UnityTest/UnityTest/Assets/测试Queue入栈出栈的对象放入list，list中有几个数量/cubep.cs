using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubep : MonoBehaviour {

	
	void Start () {
		
	}

    float timer = 0;
    bool isenqueue = false;
	void Update () {
        timer += Time.deltaTime;
        if ( timer>=2)
        {
            queue.instance.EnQueue(gameObject);
        }
	}

}
