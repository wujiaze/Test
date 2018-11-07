/*
 *      点击 Image 的触发事件的条件:
 *
 *      Image组件自身：
 *      1、Color 的alpha值，不管是0还是1，都会触发 UI事件
 *      2、RayCast Target : true:可以触发  false：不能触发
 *      3、sprite 的alpha值
 *          默认的sprite 的 alphaHitTestMinimumThreshold 为 0，意味着：sprite中alpha为0的地方，在image组件中也能触发事件
 *          所以，可以设置 alphaHitTestMinimumThreshold 大于 0 （根据具体需要改变），这意味着：在sprite中alpha小于 阈值的地方，都不会触发事件
 *          前提，sprite 对应的 texture2D 图片设置为可读可写
 *          最后阈值的设置：可以是 稍大于0 ，也可以是 1，还可以是 大于1(此时，什么都没法触发了)
 *      总结：Image 触发事件的判断：
 *             1、RayCast Target 是否为 true
 *             2、sprite 的alpha值的阈值
 *             3、之后Image组件的alpha值，对事件触发无关
 */
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestImage : MonoBehaviour, IPointerClickHandler
{
    [Range(0,2)]
    public float num;
    private Image img;
	void Start ()
	{
	    img = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
	    img.alphaHitTestMinimumThreshold = num;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("11");
    }

}
