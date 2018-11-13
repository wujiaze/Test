using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{

    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;

   
    void Start () {
        // 测试说明：1 、transform.childCount 是对象的直接子对象的数量
        print(g1.transform.childCount);
        print(g2.transform.childCount);
        print(g3.transform.childCount);
        print(g4.transform.childCount);
        // 测试说明：2 、transform 实际上是一个集合,只包含直接子对象，不包含间接子对象以及自身
        print("-------------------------");
        foreach (Transform temp in g1.transform)
        {
            print(temp.name);
        }
        print("-------------------------");
        foreach (Transform temp in g2.transform)
        {
            print(temp.name);
        }
        print("-------------------------");
        foreach (Transform temp in g3.transform)
        {
            print(temp.name);
        }
        print("-------------------------");
        foreach (Transform temp in g4.transform)
        {
            print(temp.name);
        }
        // 不能用 for 循环
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
