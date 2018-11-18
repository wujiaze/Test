using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestValuePos : MonoBehaviour
{
    private ScrollRect scroll;
    private Text txt;
    private List<RectTransform> rects;
    private int index = 10;
    void Start()
    {
        scroll = GetComponent<ScrollRect>();
        txt = Resources.Load<Text>("43_测试ScrollRect/Text");
        rects = new List<RectTransform>();
        for (int i = 0; i < index; i++)
        {
            RectTransform go = Instantiate(txt, scroll.content).rectTransform;
            go.GetComponent<Text>().text = i.ToString();
            go.name = i.ToString();
            rects.Add(go);
        }
        scroll.verticalNormalizedPosition = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // 当Content的上下内容 全部在 ViewPort框中时，为0 ,强制设置为 1 时，不受影响，依然为0

        // 当Content的上下内容 超过了 ViewPort框时
        //           当Content的上方 和 ViewPort的上方对齐时，为1
        //           当Content的下方 和 ViewPort的下方对齐时，为0


        print(scroll.verticalNormalizedPosition);       // 不受 Content 的Privot 的影响
        if (Input.GetKeyDown(KeyCode.A))
        {
            scroll.verticalNormalizedPosition = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (scroll.content.pivot == new Vector2(0, 1))
            {
                float yoffest = scroll.content.rect.height - Mathf.Abs(scroll.content.anchoredPosition.y);
                scroll.content.pivot = new Vector2(0, 0);
                scroll.content.anchoredPosition = new Vector2(scroll.content.anchoredPosition.x, -yoffest);
            }

            //scroll.content.anchorMax = new Vector2(1, 0); // 右上角
            //scroll.content.anchorMin = new Vector2(0, 0);   // 左下角
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (scroll.content.pivot == new Vector2(0, 0))
            {
                float yoffest = scroll.content.rect.height - Mathf.Abs(scroll.content.anchoredPosition.y);
                scroll.content.pivot = new Vector2(0, 1);
                scroll.content.anchoredPosition = new Vector2(scroll.content.anchoredPosition.x, yoffest);
            }

            //scroll.content.anchorMax = new Vector2(1, 1); // 右上角
            //scroll.content.anchorMin = new Vector2(0, 1);   // 左下角
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            scroll.content.pivot = new Vector2(0, 1);
        }

        AddText();
    }

    
    private void AddText()
    {
        if (scroll.verticalNormalizedPosition < 0.1f)
        {

        }
        // 向下滑，超过阈值需要添加在Top新的照片
        else if (scroll.verticalNormalizedPosition > 0.9f)
        {
            print("坐标 " + scroll.verticalNormalizedPosition);
            // 中心点不变的话，手动更改 scroll.content.anchoredPosition 效果不好，所以采用这种方法
            if (scroll.content.pivot == new Vector2(0, 1))
            {
                float yoffest = scroll.content.rect.height - Mathf.Abs(scroll.content.anchoredPosition.y);
                scroll.content.pivot = new Vector2(0, 0);
                scroll.content.anchoredPosition = new Vector2(scroll.content.anchoredPosition.x, -yoffest);
            }
            RectTransform go = Instantiate(txt, scroll.content).rectTransform;
            scroll.content.sizeDelta += new Vector2(0, go.rect.height); // 增加Content的高度
            go.transform.SetAsFirstSibling();
            index--;
            go.GetComponent<Text>().text = index.ToString();
            go.name = index.ToString();
            print("坐标 " + scroll.verticalNormalizedPosition);
            rects.Insert(0, go);

            RemoText();
        }
    }

    private void RemoText()
    {
        if (scroll.content.pivot == new Vector2(0, 0)) // bottom删除  删除的时候pivot 又要反过来
        {
            scroll.content.GetComponent<VerticalLayoutGroup>().enabled = false;
            float yoffest = scroll.content.rect.height - Mathf.Abs(scroll.content.anchoredPosition.y);
            scroll.content.pivot = new Vector2(0, 1);
            scroll.content.anchoredPosition = new Vector2(scroll.content.anchoredPosition.x, yoffest);

            RectTransform re = rects[rects.Count - 1];
            scroll.content.sizeDelta -= new Vector2(0, re.rect.height); // 增加Content的高度

            //scroll.content.anchoredPosition += new Vector2(0, re.rect.height);
            //re.gameObject.SetActive(false);
            rects.Remove(re);
            Destroy(re.gameObject);
            scroll.content.GetComponent<VerticalLayoutGroup>().enabled = true;
        }
    }

}
