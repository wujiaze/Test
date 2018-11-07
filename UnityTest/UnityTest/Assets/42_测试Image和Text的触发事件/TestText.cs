/*
 *      Text 组件的事件触发条件：
 *
 *      1、Raycast Target 的值
 *
 *
 */

using UnityEngine;
using UnityEngine.UI;

public class TestText : MonoBehaviour
{

    private Text text;
	void Start ()
	{
	    text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
            // 获取字体的锚点和中心点(即不在RectTransform组件0上显示)
	        print(Text.GetTextAnchorPivot(text.alignment));
	    }
	}
}
