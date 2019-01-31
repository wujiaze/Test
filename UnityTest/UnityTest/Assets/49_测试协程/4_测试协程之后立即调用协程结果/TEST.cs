using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// 测试说明：协程一般只用于 加载和文件写入,动画效果
//  不适合 求值的结果 ，不然会阻塞主(UI)线程
public class TEST : MonoBehaviour
{
    private string x = "0";
    void Start ()
    {
        //string x = "0";
	    IEnumerator ie = test();
        StartCoroutine(ie);
        Console.WriteLine(x);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator  test()
    {
        for (long i = 0; i < 1000000000; i++)
        {
            
        }
        UnityEngine.Debug.Log("111");
        x = "1";
        yield return null;
    }
}
