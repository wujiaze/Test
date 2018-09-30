using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageBase : MonoBehaviour {

    private void Awake()
    {
        transform.SetParent(GameObject.Find("Canvas").transform);
        transform.localPosition = Vector3.zero;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "image")
        {
Debug.Log("触发");
        }
        
    }
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    Debug.Log("触发");
    //}
}
