using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestValuePos : MonoBehaviour
{
    private ScrollRect scroll;

    void Start () {
        scroll = GetComponent<ScrollRect>();

    }
	
	// Update is called once per frame
	void Update ()
	{
        // 当Content的上下内容 全部在 ViewPort框中时，为0 ,强制设置为 1 时，不受影响，依然为0

        // 当Content的上下内容 超过了 ViewPort框时
        //           当Content的上方 和 ViewPort的上方对齐时，为1
        //           当Content的下方 和 ViewPort的下方对齐时，为0


        print(scroll.verticalNormalizedPosition);
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        scroll.verticalNormalizedPosition = 1;
	    }
    }
}
