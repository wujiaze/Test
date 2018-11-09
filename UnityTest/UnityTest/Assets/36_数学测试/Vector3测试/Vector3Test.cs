/*
 *      Vector3 结构体解析
 *       基础
 *         代数
 *          向量点乘  (a1,b1,c1,d1,....) * (a2,b2,c2,d2,....) = a1*a2 + b1*b2 + c1*c2 + d1*d2....
 *          三维向量叉乘 (a1,a2,a3) x (b1,b2,b3) = (a2*b3 - a3*b2,a3*b1-a1*b3,a1*b2-a2*b1)  获取代数式 https://en.wikipedia.org/wiki/Cross_product
 *         例子:
 *          当两个相同的向量叉乘：(a2*a3-a3*a2,a3*a1-a1*a3,a1*a2-a2*a1) = (0,0,0)
 *          当两个相反的向量叉乘：(a2*-a3 -a3 *-a2,a3*-a1 -a1*-a3,a1*-a2-a2*-a1) =（0,0,0）
 *          当向量和零向量叉乘  ：(a2 *0 -a3*0,a3*0-a1*0,a1*0-a2*0) = (0,0,0)
 *          当两个向量平行     ：(a2*n*a3-a3*n*a2,a3*n*a1-a1*n*a3,a1*n*a2-a2*n*a1) = (0,0,0)
 *         几何（二维 和 三维 有效）
 *          向量点乘 a * b = |a| * |b| * cosα
 *          向量叉乘 a x b 长度：|a| * |b| * sinα    方向：可用代数中的Z轴判断，或者右手定则
 *         上述例子也可以用几何解释：
 *          当两个相同的向量叉乘: sinα = 0 ==> 长度=0 方向:(0,0,0)
 *          当两个相反的向量叉乘：sinα = 0 ==> 长度=0 方向:(0,0,0)
 *          当向量和零向量叉乘 ：  |a| = 0 ==> 长度=0 方向:(0,0,0)
 *      一、分类
 *          1、基础类
 *              1.1、静态常数
 *                      可以用Vector3[0,1,2]来分别表示 x,y,z
 *                      Vector3.up                  ( 0, 1, 0)
 *                      Vector3.down                ( 0,-1, 0)
 *                      Vector3.left                (-1, 0, 0)
 *                      Vector3.right               ( 1, 0, 0)
 *                      Vector3.forward             ( 0, 0, 1)
 *                      Vector3.back                ( 0, 0,-1)
 *                      Vector3.one                 ( 1, 1, 1)
 *                      Vector3.zero                ( 0, 0, 0)
 *                      Vector3.positiveInfinity    (正无穷,正无穷,正无穷)
 *                      Vector3.negativeInfinity    (负无穷,负无穷,负无穷)
 *              1.2、数值转换
 *                      magnitude               向量长度(一般用来精确计算长度)
 *                      sqrMagnitude            向量长度平方(一般用来比较向量的长短，而不需要精确长度)
 *                      normalized              标准化，向量自身不改变,返回向量长度为1，方向不变
 *                      Normalize               标准化，向量自身改变,         长度为1，方向不变
 *              1.3、数值处理
 *                      Vector3.Max             返回一个新的 Vector3 ,x 为两个向量的x中较大的那个，y 为两个向量的y中较大的那个，z 为两个向量的z中较大的那个
 *                      Vector3.Min             返回一个新的 Vector3 ,x 为两个向量的x中较小的那个，y 为两个向量的y中较小的那个，z 为两个向量的z中较大的那个
 *                      Vector3.ClampMagnitude  限制向量长度，当向量小于等于限制长度时，返回原向量，当向量长度大于限制长度时，返回限制长度的向量，方向不变
 *                      Vector3.Distance        返回两向量之间的距离,当只需要比较大小时，推荐(a-b).sqrMagnitude
 *                      Vector3.Scale           缩放向量，原向量.x * scale.x   原向量.y * scale.y  原向量.z * scale.z
 *                      Vector3.Dot             向量点乘  a1*a2+b1*b2 + c1*c2
 *                                              源码：a.x*b.x + a.y*b.y + a.z*b.z  
 *                                              用途:1、根据几何意义，可以用Acos求夹角，可以用来判断一个向量对另一个向量是否可见
 *                                                   2、当没有零向量时，返回值为0 ，则为垂直
 *                                                   3、计算一个向量在另一个向量上的投影大小
 *                                                   4、计算前后方位
 *                                                      返回值大于0，结合其他(比如长度) ，判断在前方
 *                                                      返回值小于0，结合其他(比如长度) ，判断在后方
 *                                                      返回值等于0，结合其他(比如长度) ，判断在左边或右边(可再结合三维的叉乘)
 *                      
 *                      Vector3.Cross          向量叉乘
 *                                             源码  返回一个新的Vector3(a2*b3 - a3*b2,a3*b1-a1*b3,a1*b2-a2*b1)
 *                                             用途: 1、判断向量是否相交或平行
 *                                                   2、求平面的法向量
 *                                                   3、计算四边形面积
 *                                                   4、计算夹角
 *                                                   5、计算左右方位
 *                                                  
 *              1.4、曲线变换
 *                      Vector3.LerpUnclamped   线性变换（对 t 没有限制）
 *                                              原理：对两向量的x,y,z 分别使用 Mathf.LerpUnclamped => a+(b-a)*t
 *                                                    也可以整体理解，将 向量看作一个整体，进行线性插值
 *          2、复合类
 *              2.1、数值处理
 *                      Vector3.Angle           两向量的夹角，内部采用了 Vector3.Dot 点乘来计算角度
 *                                              由于同一个cosA ,可能有正负两个值，这里直接取了正值
 *                                              角度的范围[0,180]
 *                      Vector3.SignedAngle     两向量的夹角，先通过 Vector3.Angle 求值
 *                                              然后根据提供的轴向量，来计算角度的正负，例如：轴向量取 Vector3.forward(不必要一定取from和to的真正法向量，根据 点乘可知，只需要一个大致方向即可)
 *
 *
 *                      Vector3.Reflect         求 direction 相对于 法向量 normal 的 反射向量
 *                                              条件: 法向量必须是 标准化向量,法向量的方向没关系，反射向量都满足反射定律
 *
 *                      Vector3.Project         求一个向量在另一个向量上的投射向量
 *                                              当 normal向量是零向量时，投影为零向量
 *                      Vector3.ProjectOnPlane  求一个向量在一个平面上的投影 ，normal：平面的垂直向量(长度没关系)
 *              2.2、曲线变换
 *                      Vector3.Lerp            线性插值，在 Vector3.LerpUnclamped 基础上，先对t进行[0,1]限制
 *                                              类似于Mathf.Lerp,详见Update用法
 *                      Vector3.MoveTowards     移向,这个移向即可以做线性运动，也可以做非线性运动
 *                                              但是，这个函数设计出来就是为了线性运动，所以建议用作线性运动，非线性运动使用Vector3.SmoothDamp
 *                                              使用方法见Update
 *                      Vector3.SmoothDamp      平滑阻尼（随着时间的推移逐渐改变一个值到目标值）区别与线性变换Lerp
 *          3.未开源类
 *                  (对比 Vector3.Lerp)
 *                  Vector3.SlerpUnclamped      球形插值,重点：将Vector3 看作方向，而不是位置
 *                                              源码猜测：先获取旋转角度[0,180] ,可能采用了Mathf.Repeat 然后线性插值
 *                                              
 *                  Vector3.Slerp               球形插值,对t进行限制[0,1],然后和 SlerpUnclamped 一样
 *                                              效果看例子
 *                  (对比 Vector3.MoveTowards)
 *                  Vector3.RotateTowards       类似于MoveTowards,也是把向量看作方向
 *                  
 *                  Vector3.OrthoNormalize      正交归一化,todo 不是太懂  比如自己建了一个新的坐标轴，如何在自己的坐标轴和标准坐标轴之间进行切换
 */
using UnityEngine;

public class Vector3Test : MonoBehaviour
{
    public Transform lerpCube;
    public Transform movetowardsCube;
    public Transform smoothCube;
    public Transform sun;
    public Transform rotateTowardsCube;
    void Start()
    {
        print("Angle");
        print(Vector3.Angle(Vector3.right, new Vector3(1, 1, 0)));
        print(Vector3.Angle(Vector3.right, new Vector3(1, -1, 0)));
        print("SignedAngle");
        print(Vector3.SignedAngle(Vector3.right, new Vector3(1, -1, 0), Vector3.forward));
        print(Vector3.SignedAngle(Vector3.right, new Vector3(1, -1, 0), Vector3.back));
        print(Vector3.SignedAngle(Vector3.right, new Vector3(1, -1, 0), new Vector3(1, 1, 1))); // 跟 from 和 to 不垂直，但是有个大概方向 
        print("Reflect");
        print(Vector3.Reflect(Vector3.one, Vector3.up));
        print(Vector3.Reflect(Vector3.one, Vector3.down));
        print("Project");
        print(Vector3.Project(Vector3.one, Vector3.right));
        print("ProjectOnPlane");
        print(Vector3.ProjectOnPlane(Vector3.one, Vector3.up));

        // 曲线测试
        lerpStart = lerpCube.position;
        moveStart = movetowardsCube.position;
    }
    // lerp
    private Vector3 lerpStart;
    private Vector3 lerpTarget = new Vector3(10, 10, 10);
    private float timer = 0;
    private float speed = 0.5f;
    // move
    private Vector3 moveTarget = new Vector3(-10, 10, 10);
    private Vector3 moveStart;
    // smoothDamp
    private Vector3 smoothTarget = new Vector3(10, -10, 10);
    private Vector3 currentVelocity = Vector3.zero;

    // slerp
    private Vector3 sunrise = new Vector3(10, 0, 0);
    private Vector3 sunset = new Vector3(-10, 0, 0);
    private float slerptimer = 0;
    // rotateTowards
    private Vector3 rotateTarget = new Vector3(1, 0, 0);
    void Update()
    {
        // lerp
        timer += Time.deltaTime * speed;
        Vector3 temp = Vector3.Lerp(lerpStart, lerpTarget, timer);
        lerpCube.position = temp;
        //print("temp " + temp);
        // move
        Vector3 movetemp = Vector3.MoveTowards(movetowardsCube.position, moveTarget, Vector3.Distance(moveStart, moveTarget) * Time.deltaTime * speed);
        movetowardsCube.position = movetemp;
        //平滑阻尼 maxSpeed: 参考Mathf,设置为 float.PositiveInfinity 或者 Mathf.Infinity 都可以
        // 若是没有时间拉伸 deltaTime 也参考 Mathf 为 Time.deltaTime
        Vector3 smoothtemp = Vector3.SmoothDamp(smoothCube.position, smoothTarget, ref currentVelocity, 1 / speed);
        smoothCube.position = smoothtemp;

        // slerp 球形插值
        slerptimer += Time.deltaTime * speed;
        Vector3 center = (sunrise + sunset) * 0.5F;
        center -= new Vector3(0, 1, 0);         // 防止中心点为0
        Vector3 riseRelCenter = sunrise - center;
        Vector3 setRelCenter = sunset - center;
        sun.position = Vector3.Slerp(riseRelCenter, setRelCenter, slerptimer);
        sun.position += center;

        // 旋转移向(转向)
        // todo 其中 maxMagnitudeDelta 不是太明白，设0即可
        Vector3 targetDir = rotateTarget - rotateTowardsCube.position;
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(rotateTowardsCube.forward, targetDir, step, 0);
        rotateTowardsCube.LookAt(newDir);
    }
    
    
}
