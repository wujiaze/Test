/*
 *      Vector2 结构体解析
 *      基础
 *      向量点乘 (a1,b1,c1,d1,....) * (a2,b2,c2,d2,....) = a1*a2 + b1*b2 + c1*c2 + d1*d2....
 *      三维向量叉乘 (a1,b1,c1) x (a2,b2,c2) = (b1*c2-b2*c1,a1*c2-a2*c1,a1*b2-a2*b1)
 *      二维向量的叉乘(a1,b1,0) x (a2,b2,0) = (0,0,a1*b2-a2*b1); 几何上是不存在的但是可以拿来用
 *      一、分类
 *          1、基础类
 *              1.1、静态常数
 *                      Vector2.up                  (0, 1)
 *                      Vector2.down                (0,-1)
 *                      Vector2.left                (-1,0)
 *                      Vector2.right               ( 1,0)
 *                      Vector2.one                 ( 1,1)
 *                      Vector2.zero                ( 0,0)
 *                      Vector2.positiveInfinity    (正无穷，正无穷)
 *                      Vector2.negativeInfinity    (负无穷，负无穷)
 *              1.2、数值转换
 *                      magnitude               向量长度(一般用来精确计算长度)
 *                      sqrMagnitude            向量长度平方(一般用来比较向量的长短，而不需要精确长度)
 *                      normalized              标准化，向量自身不改变,返回向量长度为1，方向不变
 *                      Normalize               标准化，向量自身改变,         长度为1，方向不变
 *              1.3、数值处理
 *                      Vector2.Max             返回一个新的 Vector2 ,x 为两个向量.x中较大的那个，y 为两个向量.y中较大的那个
 *                      Vector2.Min             返回一个新的 Vector2 ,x 为两个向量.x中较小的那个，y 为两个向量.y中较小的那个
 *                      Vector2.ClampMagnitude  限制向量长度，当向量小于等于限制长度时，返回原向量，当向量大于限制长度时，返回限制长度的向量
 *                      Vector2.Distance        返回两向量之间的距离      
 *                      Vector2.Dot             向量点乘  a1*a2+b1*b2
 *                                              源码：a.x*b.x + a.y*b.y   
 *                                              用途:1、根据几何意义，可以用Acos求夹角，可以用来判断一个向量对另一个向量是否可见
 *                                                   2、当没有零向量时，返回值为0 ，则为垂直
 *                                                   3、计算一个向量在另一个向量上的投影大小
 *                                                   4、返回值大于0，结合其他(比如长度) ，判断在前方
 *                                                      返回值小于0，结合其他(比如长度) ，判断在后方
 *                                                      返回值等于0，结合其他(比如长度) ，判断在左边或右边(可再结合三维的叉乘)
 *                      Vector2.Scale           缩放向量，原向量.x * sclae.x   原向量.y * sclae.y
 *              1.4、曲线变换
 *                      Vector2.LerpUnclamped   线性变换（对 t 没有限制）
 *                                              原理：对两向量的x,y 分别使用 Mathf.LerpUnclamped
 *                                                    也可以整体理解，将 向量看作一个整体，进行线性插值
 *          2、复合类
 *              2.1、
 *                      Vector2.Angle           两向量的夹角，内部采用了 Vector2.Dot 点乘来计算角度
 *                                              由于同一个cosA ,可能有正负两个值，这里直接取了正值
 *                                              角度的范围[0,180]
 *                      Vector2.SignedAngle     两向量的夹角，先通过 Vector2.Angle 求值，在通过叉乘的Z轴的正负，来判断角的正负
 *                                              又由于 Mathf.sign: 0 为正，所以角度的取值范围(-180,180]
 *                      Vector2.Reflect         求 direction 相对于 法向量 normal 的 反射向量
 *                                              准确的条件: 法向量必须是 标准化向量
 *              2.2、曲线变换
 *                      Vector2.Lerp            线性插值，类似于Mathf.Lerp,详见用法
 *                      Vector2.MoveTowards     移向,这个移向即可以做线性运动，也可以做非线性运动
 *                                              但是，这个函数设计出来就是为了线性运动，所以建议用作线性运动，非线性运动 使用   Vector2.SmoothDamp
 *                                              使用方法见Update
 *                      Vector2.SmoothDamp      平滑阻尼（随着时间的推移逐渐改变一个值到目标值）区别与线性变换Lerp
 */
using UnityEngine;

public class Vector2Test : MonoBehaviour
{
    public Transform LerpCube;
    public Transform MoveTowardsCube;
    public Transform SmoothCube;
    void Start()
    {
        print(Vector2.Reflect(Vector2.one, Vector2.down));
        moveStart = MoveTowardsCube.position;
    }

    private Vector2 start = Vector2.zero;
    private Vector2 target = new Vector2(10, 5);
    private float timer = 0;
    private float speed = 0.5f;

    private Vector2 moveTarget = new Vector2(10,-5);
    private Vector2 moveStart;

    private Vector2 smoothTarget = new Vector2(10,0);
    private Vector2 currentVelocity = Vector2.zero;
    void Update()
    {
        timer += Time.deltaTime * speed;
        Vector2 temp = Vector2.Lerp(start, target, timer);                      // 线性插值：根据 线性参数timer的大小(内部限制为[0,1]),线性的获取插值
        LerpCube.position = new Vector3(temp.x, temp.y, LerpCube.position.z);


        Vector2 movetemp = Vector2.MoveTowards(MoveTowardsCube.position, moveTarget, Vector2.Distance(moveTarget,moveStart) * Time.deltaTime * speed);
        MoveTowardsCube.position = new Vector3(movetemp.x, movetemp.y, MoveTowardsCube.position.z);

        //平滑阻尼 maxSpeed: 参考Mathf,设置为 float.PositiveInfinity 或者 Mathf.Infinity 都可以
        // 若是没有时间拉伸 deltaTime 也参考 Mathf 为 Time.deltaTime
        Vector2 smoothtemp =Vector2.SmoothDamp(SmoothCube.position, smoothTarget, ref currentVelocity, 1 / speed,float.PositiveInfinity, Time.deltaTime);
        SmoothCube.position = new Vector3(smoothtemp.x, smoothtemp.y, SmoothCube.position.z);
    }
}
