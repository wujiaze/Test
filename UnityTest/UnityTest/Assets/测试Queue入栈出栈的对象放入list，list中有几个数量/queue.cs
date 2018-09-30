using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class queue : MonoBehaviour {

    public static queue instance;
    private void Awake()
    {
        instance = this;
    }
    void Start () {
		
	}
	
	// 通过测试表明：queue和list中保留的都是对象（内存）的引用，当对象销毁时，即内存中消失，list和queue中的引用指向null
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject temp = DeQueue();
            objList.Add(temp);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("objQueue.Count" + objQueue.Count);
            Debug.Log("objList.Count" + objList.Count);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Destroy(DeQueue());
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (var item in objList)
            {
                Debug.Log(item);
            }
           
        }
	}
    public GameObject objprefab;

    Queue<GameObject> objQueue = new Queue<GameObject>();

    public void EnQueue(GameObject obj) {
        obj.SetActive(false);
        objQueue.Enqueue(obj);
    } 
    public GameObject DeQueue()
    {
        GameObject obj = null;
        if (objQueue.Count > 0)
        {
            obj = objQueue.Dequeue();
            obj.SetActive(true);
        }
        else {
            obj = Instantiate(objprefab);
        }
        return obj;
    }

    List<GameObject> objList = new List<GameObject>();
    public void addList() {

    }
    public void ClearList() {
    }
}
