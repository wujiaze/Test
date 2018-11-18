using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIeventTest : MonoBehaviour
{

    public Button btn;
	void Start () {
	    btn.onClick.AddListener(Pi); // 多次添加，则相当于事件，全部都会调用 ，添加几次，调用几次
	    btn.onClick.AddListener(Pi);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Pi()
    {
        print("11");
    }
}
