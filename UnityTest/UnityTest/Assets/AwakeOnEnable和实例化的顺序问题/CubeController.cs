using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("ff");
    }
    private void OnEnable()
    {
        GameObject cp = Resources.Load<GameObject>("CubePrefab");
        GameObject newcp = Instantiate(cp);
        Debug.Log(newcp.transform.localScale);
        //newcp.transform.localScale = new Vector3(2, 2, 2);
    }
    void Start () {
        //GameObject cp = Resources.Load<GameObject>("CubePrefab");
        //cp.transform.localScale = new Vector3(2, 2, 2);
    }
	
	
	void Update () {
		
	}
}
