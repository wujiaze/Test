using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outinstance : MonoBehaviour {

    public static outinstance instance;
    private void Awake()
    {
        instance = this;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void gettime() {
        for (int i = 0; i < 10000; i++)
        {
            Debug.Log(i);
        }
    }
}
