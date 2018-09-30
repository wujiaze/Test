using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // 测试说明 同一个物体只能碰撞检测一次
    // 测试说明 在触发或碰撞中，如果销毁物体，本次碰撞或触发全部走完之后才会结束
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "image")
        {
            Debug.Log(collider.name);
            Destroy(gameObject);
            if (gameObject!=null)
            {
                gameObject.GetComponent<BoxCollider2D>().size = new Vector2(100, 100) * 5;
            }
            Debug.Log("删除了自身，触发会进行结束吗");

        }
    }
    // 测试说明 同一个物体只能碰撞检测一次
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "image")
        {
            Debug.Log(collision.transform.name);
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(100, 100) * 5;
        }
    }
}
