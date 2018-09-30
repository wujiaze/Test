using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMono : MonoBase
{
    // 前提：父类继承了 MonoBehaviour
    // 测试说明：
    // 1、 Unity会先执行 父类的回调方法，再执行子类的回调方法
    // 2、 当父类显示写出 Unity 的回调方法，而子类没有显示写出回调方法，则子类会调用父类的那个回调方法
   
    private void Awake()
    {
        Debug.Log("子类Awake");
        //baselist = new List<int>();
        //baselist.Add(1);
    }

    private void Start()
    {
       Debug.Log("子类Start");
     }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("子类Updte");
            Debug.Log(baselist.Count);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
          Show();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Add(1);
        }
    }
}
