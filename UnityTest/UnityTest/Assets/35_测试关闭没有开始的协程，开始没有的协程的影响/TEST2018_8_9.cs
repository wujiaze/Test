using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST2018_8_9 : MonoBehaviour {

	// 测试说明: 不能开始不存在的协程
    //          可以停止 未开启的协程
    //          可以停止 不存在的协程
                    
	void Start () {
	    StopCoroutine("Do");
	    StopCoroutine("rt");
	    //StartCoroutine("rt");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private IEnumerator Do()
    {
        while (true)
        {
            Debug.Log("A");
            yield return null;
        }
    }
}
