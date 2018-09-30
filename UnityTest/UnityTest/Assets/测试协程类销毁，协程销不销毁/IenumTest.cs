using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IenumTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Py(1));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator  Py(int x) {
        while (x>0)
        {
            x++;
            Debug.Log(x);
            yield return null;
        }
    }
}
