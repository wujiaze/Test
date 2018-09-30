using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tesonobj : MonoBehaviour
{
    public static tesonobj instance;
    public GameObject cubeprefab;
    public Transform parent;
    public Transform target;
    void Awake()
    {
        instance = this;
    }

    void Start () {
		
	}
    // 测试说明：当实例化对象时，会走Awake OnEnable, 然后主脚本中若是给实例化对象赋值，
    // 值类型：第一次赋值，在Start中，能够获取主脚本赋值更新的值，之后第二次从对象池中唤醒时，OnEnable中是不会更新到主脚本中新的赋值，
    // 所以，当赋新的值时采用在实例化对象的脚本中的Update中更新，这样比较好
    // 引用类型：第一次赋值时，就将引用给了实例化对象，所以在第二次唤醒时，引用的对象的数值更换了，不管在Onenable还是Update中，都可以更新新的值
    // 注意点在值类型，所以总体来说，就在Update中更新，然后用bool值来使之只进行一次更新
    public Queue<GameObject> objlist = new Queue<GameObject>();
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        GameObject temp = null;
	        if (objlist.Count > 0)
	        {
	            temp = objlist.Dequeue();
                temp.SetActive(true);
	        }
	        else
	        {
	            temp = Instantiate(cubeprefab, parent);
	        }
	        cubebase1 tempbase = temp.GetComponent<cubebase1>();
	        tempbase.trans = target;
            tempbase.pos =new Vector3(100,100,100);
	    }
	    if (Input.GetKeyDown(KeyCode.M))
	    {
	        GameObject temp = null;
	        if (objlist.Count > 0)
	        {
	            temp = objlist.Dequeue();
	            temp.SetActive(true);
	        }
	        else
	        {
	            temp = Instantiate(cubeprefab, parent);
	        }
	        cubebase1 tempbase = temp.GetComponent<cubebase1>();
	        tempbase.pos = new Vector3(300, 100, 100);
	    }
    }
}
