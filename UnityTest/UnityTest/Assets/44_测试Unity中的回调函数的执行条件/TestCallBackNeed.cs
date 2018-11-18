using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCallBackNeed : MonoBehaviour {

    private void Awake()
    {
        // 当附着的对象 不激活时，脚本不管激活还是没激活，不会调用Awake 以及其他回调函数
        // 当附着的对象 激活时 ，脚本不激活，会调用 Awake，但不会调用其他回调
        print("Awake");
    }

    private void OnEnable()
    {
        // 只有附着的对象激活，且脚本激活，才会调用 OnEnable
        print("OnEnable");
    }
    void Start()
    {
        // 只有附着的对象激活，且脚本激活，并且是第一次，才会调用 Start
        print("Start");
    }
    private void OnDisable()
    {
        // 当脚本从激活到不激活，会调用 OnEnable
        // 比如：附着的对象 不激活、销毁
        // 比如：脚本自身不激活
        print("OnDisable");
    }

    private void OnDestroy()
    {
        // 脚本销毁，运行停止
        print("OnDestroy");
    }

    private void OnApplicationQuit() // 先于OnDestroy
    {
        // 运行停止
        print("OnApplicationQuit");
    }



   
	
	// Update is called once per frame
	void Update () {
		
	}
}
