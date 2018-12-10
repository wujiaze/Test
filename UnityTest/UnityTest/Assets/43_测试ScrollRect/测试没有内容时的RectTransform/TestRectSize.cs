/*
 *  
 */
using UnityEngine;
using UnityEngine.UI;

public class TestRectSize : MonoBehaviour
{
    private ScrollRect scrollRect;

    void Start()
    {
        scrollRect = transform.GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        // scrollRect 的Content 在没有内容时，是有宽度的
        if (Input.GetKeyDown(KeyCode.A))
        {
            print(scrollRect.content.sizeDelta.x); // 受锚点影响，永远跟面板上显示的一样
            print(scrollRect.content.rect.width);   // 不受锚点影响，永远是真实尺寸的大小
        }
    }
}
