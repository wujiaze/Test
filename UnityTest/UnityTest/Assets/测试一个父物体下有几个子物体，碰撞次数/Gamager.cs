using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamager : MonoBehaviour {

    public GameObject mouse;
    public static List<string> ddd = new List<string>();
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            mouse.SetActive(true);
        }
	}
}
