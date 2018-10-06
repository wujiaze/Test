using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mm1 : MonoBehaviour {

	
	void Start ()
	{
       
	   
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        print("111");
	    }
	    if (Input.GetKeyDown(KeyCode.B))
	    {
	        StartCoroutine(test());
	    }
        if (Input.GetKeyDown(KeyCode.C))
	    {
	        StartCoroutine(test2());
        }
	}
    /* 测试说明： 协程中的死循环也会造成主线程卡死，因为协程就是在主线程中进行的*/
    private IEnumerator test()
    {
        while (true)
        {
            
        }
        yield return null;
    }

    /* 测试说明： 一个协程中有耗时的方法，只要有yield return ，那么下一个协程就会等待这个协程完成之后，再开始*/
    private IEnumerator test2()
    {
        StartCoroutine(test3());
        print("33");
        yield return null;
        print("44");
    }

    private IEnumerator test3()
    {
        print("22");
        yield return new WaitForSeconds(1);
    }
}
