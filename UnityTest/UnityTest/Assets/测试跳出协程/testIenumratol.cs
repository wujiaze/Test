using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class testIenumratol : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(testenum(""));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // 测试说明：条件不成立，跳出协程使用 yield break;
    IEnumerator testenum(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
           Debug.Log("name 为 null");
           yield break ; 
        }
        Debug.Log("is here");
    }
}
