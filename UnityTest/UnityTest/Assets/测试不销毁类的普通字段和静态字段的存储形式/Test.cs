using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour {

    private int x;
    private static int y;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x++;
        Debug.Log("x" + x);
        y++;
        Debug.Log("y"+y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
	}
}
