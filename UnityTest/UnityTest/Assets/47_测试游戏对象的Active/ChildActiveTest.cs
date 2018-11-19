using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 测试表明：子物体就算自身 activeself 为 true ，但是 activeInHierarchy 为false ，也会调用 子对象的 OnDisable
public class ChildActiveTest : MonoBehaviour {

    private void OnEnable()
    {
        print("Child  OnEnable");
    }

    private void OnDisable()
    {
        print("Child  OnDisable");
    }


}
