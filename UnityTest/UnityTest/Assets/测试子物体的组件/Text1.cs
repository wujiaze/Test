using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text1 : MonoBehaviour {

    public GameObject textOBJ; 
	void Start () {
        textOBJ.transform.GetComponentInChildren<Text>(true).text = "10"; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
