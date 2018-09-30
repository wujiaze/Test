using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tritest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    // 测试说明1：只有自身有碰撞器，才会触发自身的回调函数
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dddd");
    }
    

    
}
