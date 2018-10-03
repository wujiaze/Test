using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour {

	
	void Start () {
	    GameEnableTest.Instance.gameObject.SetActive(false);
    }
	
	/* 测试表明: 在 gameobject 为false时，是可以触发 其余组件的，GameObject组件也可以触发（setEnable）
	            就是 一些回调函数不执行 
         */
                
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        GameEnableTest.Instance.transform.localScale = new Vector3(10,10,10);

        }	
	}


}
