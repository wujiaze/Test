using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBase : MonoBehaviour
{
    // 测试结果
    // 1、当 public 修饰的一些对象或者 SerializeField 暴露在面板时，都会自动初始化
    // 2、当父类中有初始化，不管是什么修饰符，子类都会对这个字段进行初始化（符合继承），父类和子类是不一样的引用

    public List<int> baselist = new List<int>();

    private List<int> prilist =new List<int>();
    private void Awake()
    {
        Debug.Log("父类Awake");
        //baselist = new List<int>();
        baselist.Add(1);
    }

    
    private void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
            Debug.Log("父类Update");
	        Debug.Log(baselist.Count);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Show();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Add(1);
        }
    }

    public void Show()
    {
        Debug.Log(prilist.Count);
    }

    public void Add(int x)
    {
        prilist.Add(x);
    }
}
