using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameteata : MonoBehaviour {

    public GameObject cubeprafab;
    public static gameteata instance;
    Vector3[] v;
    void Start () {
        instance = this;
        Vector3 v3 = new Vector3(1, 1, 1);
        Vector3 v32 = new Vector3(3, 0, 0);
        v= new Vector3[] { v3, v32 };
    }
    // 测试表明：当同一个物体被多次推入同一个队列时，从队列中取出这个对象，就会取出两次，并且不会触发脚本中的任何方法，所以这是非常危险的
    // 一定要注意：在对象池中不能让同一个对象多次放入一个队列，
    public Queue<GameObject> queue = new Queue<GameObject>();
    int i =0;
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (queue.Count > 0)
            {
                GameObject temp = queue.Dequeue();
                temp.transform.position = v[i];
                i++;
                temp.SetActive(true);
                if (i ==2)
                {
                    i = 0;
                }
            }
            else {
                Instantiate(cubeprafab,new Vector3(0,0,0),Quaternion.identity);
            }
        }
	}
}
