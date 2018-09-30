using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene2test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Destroy(this.gameObject);
            invokeTest.instance.Get(0);
            invokeTest.instance.Get(1);
            invokeTest.instance.Get(2);

            SceneManager.LoadSceneAsync(3, LoadSceneMode.Single);
        }
    }
}
