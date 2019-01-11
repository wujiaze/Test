/*
 *  ScrollRect 组件的 横向、纵向滑动条删除时，必须将ScrollRect中对应的属性设置为None，Missing会出错
 */
using UnityEngine;
using UnityEngine.UI;

public class TestRectSize : MonoBehaviour
{
    private ScrollRect scrollRect1;

    private GameObject panel;
    private ScrollRect scrollRect2;
    private void Awake()
    {
        scrollRect1 = transform.Find("Scroll View1").GetComponent<ScrollRect>();
        scrollRect1.gameObject.SetActive(false);

        panel = transform.Find("Panel").gameObject;
        panel.SetActive(false);
        //scrollRect2 = transform.Find("GameObject/Scroll View2").GetComponent<ScrollRect>();
        //scrollRect2.gameObject.SetActive(false);
    }


    void Start()
    {
        //scrollRect = transform.Find("Scroll View").GetComponent<ScrollRect>();
        //scrollRect.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // scrollRect 的Content 在没有内容时，是有宽度的
        if (Input.GetKeyDown(KeyCode.A))
        {
            print(scrollRect1.content.sizeDelta.x); // 受锚点影响，永远跟面板上显示的一样
            print(scrollRect1.content.rect.width);   // 不受锚点影响，永远是真实尺寸的大小
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            scrollRect1.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            scrollRect1.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            scrollRect2.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            scrollRect2.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            panel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            panel.SetActive(false);
        }
    }
}
