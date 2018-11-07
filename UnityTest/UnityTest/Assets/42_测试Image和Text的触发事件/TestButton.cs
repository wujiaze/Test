/*
 *      Button 触发事件的条件
 *
 *      1、Image 触发条件的第三点
 *      2、Interactable 的值：true：可触发 false：不可触发
 */
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestButton : MonoBehaviour, IPointerClickHandler
{

    [Range(0, 2)]
    public float num;
    private Image img;
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        img.alphaHitTestMinimumThreshold = num;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("22");
    }
}
