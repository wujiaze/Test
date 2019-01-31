using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCor : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(IENUM1());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // 测试说明：这样也是一种开启协程的方法  yield return + 协程名
    IEnumerator IENUM1()
    {
        Debug.Log("start");
        yield return IENUM2();
    }

    IEnumerator IENUM2()
    {
        Debug.Log("2");
        yield return null;
    }
}
