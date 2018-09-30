using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInitTest : MonoBehaviour {

    public List<bool> boolList =new List<bool>();
    public static List<bool> boolList2 =new List<bool>();
    // 测试说明： 实例化字段和静态字段在Awake 之前
    private void Awake()
    {
        print(boolList);
        print(boolList2);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
