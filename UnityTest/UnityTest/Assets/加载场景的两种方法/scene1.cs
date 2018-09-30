using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(5,LoadSceneMode.Single);
            for (int i = 0; i < 10000; i++)
            {
                Debug.Log(i);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadSceneAsync(5, LoadSceneMode.Single);
            for (int i = 0; i < 10000; i++)
            {
                Debug.Log(i);
            }
        }
    }

}
