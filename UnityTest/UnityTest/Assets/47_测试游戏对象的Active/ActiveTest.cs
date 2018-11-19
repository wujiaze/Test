using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTest : MonoBehaviour
{

    public GameObject Parent;
    public GameObject Child;
	void Start () {
		
	}

    /*
	 *  测试可知：
	 *  当父物体 false 子物体 true 时, 子物体的 activeSelf 为true ，activeInHierarchy 为false
     *  只有当子物体自身为 false时， activeSelf 和 activeInHierarchy 都为false
	 */
    void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        Parent.SetActive(true);
            Child.SetActive(true);

            Parent.SetActive(false);
            print("Parent.activeInHierarchy "+Parent.activeInHierarchy);
	        print("Parent.activeSelf "+Parent.activeSelf);
	        print("Child.activeInHierarchy  "+Child.activeInHierarchy);
	        print("Child.activeSelf "+Child.activeSelf);
        }
	    if (Input.GetKeyDown(KeyCode.B))
	    {
	        Parent.SetActive(true);
	        Child.SetActive(true);

	        Child.SetActive(false);
	        print("Parent.activeInHierarchy " + Parent.activeInHierarchy);
	        print("Parent.activeSelf " + Parent.activeSelf);
	        print("Child.activeInHierarchy  " + Child.activeInHierarchy);
	        print("Child.activeSelf " + Child.activeSelf);
	        
	    }
    }
}
