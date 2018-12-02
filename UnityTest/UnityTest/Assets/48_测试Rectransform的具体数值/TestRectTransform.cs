/*
 *
 *    offsetMax 定义
 *      offsetMax.x = 矩形的 right边  减 右边的两个锚点连成的线或点 的位置   在属性面板中的 Right 的值是 offsetMax.x 的相反数
 *      offsetMax.y = 矩形的 upper边  减 上面的两个锚点连成的线或点 的位置   在属性面板中的 Top   的值是 offsetMax.y 的相反数
 *    offsetMin 定义
 *      offsetMin.x = 矩形的 left边   减 左边的两个锚点连成的线或点 的位置   在属性面板中的 Left   的值就是 offsetMin.x  
 *      offsetMin.y = 矩形的 bottom边 减 下面的两个锚点连成的线或点 的位置   在属性面板中的 Bottom 的值就是 offsetMin.y
 *
 *      offsetMax 和  offsetMin 的值不受 Transform 的影响
 *
 *
 *    sizeDelta 定义
 *       当锚点是一个点时，sizeDelta.x = ImgRect2.rect.width  sizeDelta.y = ImgRect2.rect.height
 *       当锚点是是四边形时
 *                         sizeDelta.x = 矩形的Width - 锚点四边形的Width
 *                         sizeDelta.y = 矩形的Height - 锚点四边形的Height
 *       当锚点是一条线时
 *                     竖线 sizeDelta.x = 矩形的Width                       sizeDelta.y = 矩形的Height - 锚点四边形的Height
 *                     横线 sizeDelta.x = 矩形的Width - 锚点四边形的Width    sizeDelta.y = 矩形的Height
 *
 *    sizeDelta的值不受 Transform 的影响
 *
 *    向量理解(推荐)
 *  
 */
using UnityEngine;
public class TestRectTransform : MonoBehaviour
{

    public RectTransform ImgRect1; // 锚点是一个点
    public RectTransform ImgRect2; // 锚点是一条线
    public RectTransform ImgRect3; // 锚点是四个点

    public RectTransform ImgRect4;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 测试的时候可以任意移动锚点,但是锚点需要保持为一个点
            // 测试可知,锚点是一个点时
            //          PosX PosY     为中心点和锚点的相对位置
            //          Width，Height 为矩形的宽和高 等于  ImgRect1.rect.size
            print("矩形的大小：" + ImgRect1.rect.size);
            print(ImgRect1.sizeDelta);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            // 锚点是一条竖线
            print("矩形的大小："+ImgRect2.rect.size);
            print(ImgRect2.sizeDelta); 
            print(ImgRect2.offsetMax); 
            print(ImgRect2.offsetMin);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            // 锚点是一条竖线
            print("矩形的大小：" + ImgRect3.rect.size);
            print(ImgRect3.sizeDelta);
            print(ImgRect3.offsetMax);
            print(ImgRect3.offsetMin);
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ImgRect3.sizeDelta = new Vector2(0, ImgRect3.sizeDelta.y);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // 
            ImgRect4.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,100);

            //ImgRect1.SetInsetAndSizeFromParentEdge();
        }
    }
}
