using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{

    private List<GameObject> list =new List<GameObject>();
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;

    // 测试说明：list中应用对象的index会自动变化
    void Start () {
	    list.Add(obj1);
	    list.Add(obj2);
	    list.Add(obj3);
	    list.Add(obj4);
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(i + "" + list[i].name);
        }

        list.Remove(obj2);
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(i+""+ list[i].name);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
