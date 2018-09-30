using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testConstructor : MonoBehaviour {

    // 测试说明：继承mono的类最好不要用构造函数，因为你无法判断这个构造函数什么时候会被调用
    //          而且不管是内部还是外部，都没办法通过构造函数来实例化对象
    private testConstructor()
    {
        Debug.Log("here");
    }

    void Start ()
    {
        //testConstructor s = new testConstructor();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
