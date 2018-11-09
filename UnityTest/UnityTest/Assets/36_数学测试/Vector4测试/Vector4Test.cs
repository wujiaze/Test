/*
 *      Vector4 结构体解析
 *       基础
 *         代数
 *          向量点乘  (a1,b1,c1,d1,....) * (a2,b2,c2,d2,....) = a1*a2 + b1*b2 + c1*c2 + d1*d2....
 *      一、分类
 *          1、基础类
 *              1.1、静态常数
 *                      可以用Vector4[0,1,2,3]来分别表示 x,y,z,w
 *                      Vector4.one                 ( 1, 1, 1, 1)
 *                      Vector4.zero                ( 0, 0, 0, 0)
 *                      Vector4.positiveInfinity    (正无穷,正无穷,正无穷,正无穷)
 *                      Vector4.negativeInfinity    (负无穷,负无穷,负无穷,负无穷)
 *              1.2、数值转换
 *                      magnitude               向量长度(一般用来精确计算长度) sqrt(x*x + y*y + z*z + w*w) 
 *                      sqrMagnitude            向量长度平方(一般用来比较向量的长短，而不需要精确长度) (x*x + y*y + z*z + w*w) 
 *                      normalized              标准化，向量自身不改变,返回向量长度为1，方向不变
 *                      Normalize               标准化，向量自身改变,         长度为1，方向不变
 *              1.3、数值处理
 *                      Vector4.Max             返回一个新的 Vector4 ,x 为两个向量的x中较大的那个，y 为两个向量的y中较大的那个，z 为两个向量的z中较大的那个，w 为两个向量的w中较大的那个
 *                      Vector4.Min             返回一个新的 Vector4 ,x 为两个向量的x中较小的那个，y 为两个向量的y中较小的那个，z 为两个向量的z中较小的那个，w 为两个向量的w中较小的那个
 *                      Vector4.Distance        返回两向量之间的距离,当只需要比较大小时，推荐(a-b).sqrMagnitude
 *                      Vector4.Scale           缩放向量，原向量.x * scale.x   原向量.y * scale.y  原向量.z * scale.z  原向量.w * scale.w
 *                      Vector4.Dot             向量点乘  a1*a2 + b1*b2 + c1*c2 + d1*d2
 *                                              源码：a.x*b.x + a.y*b.y + a.z*b.z  + a.w*b.w
 *                                              用途:不是很明确，因为四维目前没有几何意义
 *              1.4、曲线变换
 *                      Vector4.LerpUnclamped   线性变换（对 t 没有限制）
 *                                              原理：对两向量的x,y,z,w 分别使用 Mathf.LerpUnclamped => a+(b-a)*t
 *                                                    也可以整体理解，将 向量看作一个整体，进行线性插值
 *          2、复合类
 *              2.1、数值处理
 *                      Vector4.Project         求一个向量在另一个向量上的投射向量
 *                                              和三维向量一样的公式，但是不是很清楚物理意义
 *              2.2、曲线变换
 *                      Vector4.Lerp            线性插值，在 Vector4.LerpUnclamped 基础上，先对t进行[0,1]限制
 *                                              类似于Mathf.Lerp,详见Update用法
 *                      Vector4.MoveTowards     移向,这个移向即可以做线性运动，也可以做非线性运动
 *                                              但是，这个函数设计出来就是为了线性运动，所以建议用作线性运动，非线性运动使用Vector4.SmoothDamp
 *                                              使用方法见Update
 */
using UnityEngine;

public class Vector4Test : MonoBehaviour
{
    void Start()
    {
        print(Vector4.Project(Vector4.one, new Vector4(1, 0, 0, 0)));

    }

    private Vector4 start = Vector4.zero;
    private Vector4 target = new Vector4(10, 10, 10, 10);
    private float timer = 0;
    private float speed = 0.5f;
    void Update()
    {
        timer += Time.deltaTime * speed;
        Vector4 lerptemp = Vector4.Lerp(start, target, timer);
        print("lerptemp " + lerptemp);

        /*
         *     Vector4.MoveTowards
         *     由于没有合适的几何意义，这里就不在举例
         */

    }
}
