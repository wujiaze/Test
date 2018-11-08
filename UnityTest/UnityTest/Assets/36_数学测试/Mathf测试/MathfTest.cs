/*
 *      Mathf 结构体解析
 *
 *      一、分类
 *          1、基础类
 *              1.1、静态常数
 *                      Mathf.Deg2Rad                               从角度转到弧度的常数
 *                      Mathf.Rad2Deg                               从弧度转到角度的常数
 *                      Mathf.Epsilon                               区别于 0 的最小浮点数
 *                      Mathf.Infinity                              正无穷大
 *                      Mathf.NegativeInfinity                      负无穷大
 *                      Mathf.PI                                    圆周率 π 的值
 *              1.2、三角函数(参数弧度角)
 *                      Mathf.Sin                                   弧度角的正弦值
 *                      Mathf.Cos                                   弧度角的余弦值
 *                      Mathf.Tan                                   弧度角的正切值
 *                      Mathf.Asin                                  通过反正弦求弧度角
 *                      Mathf.Acos                                  通过反余弦求弧度角
 *                      Mathf.Atan                                  通过反正切求弧度角
 *                      Mathf.Atan2                                 通过反正切2求弧度角(推荐，因为这个可以求90度，即x=0，也能求值)
 *              1.3、数值转换
 *                      Mathf.Abs                                   绝对值
 *                      Mathf.Ceil                                  向上取整(返回 float)
 *                      Mathf.CeilToInt                             向上取整(返回 int)
 *                      Mathf.Floor                                 向下取整(返回 float)
 *                      Mathf.FloorToInt                            向下取整(返回 int)
 *                      Mathf.Clamp                                 限制取值范围
 *                      Mathf.Clamp01                               限制取值范围，范围[0,1]
 *                      Mathf.Exp                                   自然指数 e 的次方数
 *                      Mathf.Log                                   取对数 f：值  p: 对数的底(默认为 自然指数 e)
 *                      Mathf.Log10                                 取对数 f: 值     对数的底为10
 *                      Mathf.Pow                                   取指数 f: 底  p: 指数
 *                      Mathf.Sqrt                                  开方数(小于0，返回NaN)
 *                      Mathf.Round                                 返回最近的数，当0.5结尾时，返回最近的两个数之中的偶数
 *                      Mathf.RoundToInt                            返回值转换为Int
 *              1.4、数值处理
 *                      Mathf.Max                                   最大值(两个数，一个数组)
 *                      Mathf.Min                                   最小值(两个数，一个数组)
 *                      Mathf.Sign（f）                              返回值 1：正 0：负。特别的 0为返回为1，表示正
 *              1.5、曲线变换
 *                      Mathf.LerpUnclamped(a,b,t)                  返回值 = a + (b - a) * t  ,就是一个普通的线性变换，可以看成一个函数：f(x) = ax + b
 *          2、复合类
 *              2.1、数值处理
 *                      Mathf.Approximately                         比较两个浮点值，是否相近(精度在E-40)，推荐使用（因为在上亿次计算中 1.0 == 10.0 / 10.0，也有可能出错）
 *
 *                      Mathf.DeltaAngle                            获取两个角的最小夹角，范围在(-180,180]
 *                                                                  原理：先 Repeat(target-current,360),并且大于180时，减去180
 *
 *                      Mathf.InverseLerp(from,to,value)            反插值,计算两个值之间的Lerp参数
 *                                                                  原理 ： 插值 = value-from/ to-from，然后再使用 Mathf.Clamp01 进行限制
 *
 *              2.2、曲线变换
 *                      Mathf.Repeat(t,length)                      周期性重复或者说周期性限制  每当 t 大于等于 length ，就返回 t % length
 *
 *                      Mathf.PingPong                              周期性重复(曲线类似乒乓)
 *                                                                  原理 ： 内部就是 Mathf.Repeat ，外加一些处理
 *
 *                      Mathf.Lerp(start,end,t)                     线性插值
 *                                                                  原理： 返回值 = (end - start)* Clamp01(t) + start,就是一种普通的线性变换 ,并且内部对 t 做了限制范围是[0,1]
 *                                                                  建议使用方式：start 和 end 在Update中都是不变的，改变的是 t，可以累加，也可以减少
 *                                                                  用法:详见Update
 *                      Mathf.LerpAngle(a,b,t)                      角度线性插值
 *                                                                  原理：先使用 Mathf.DeltaAngle(b-a,360) ，然后使用 Lerp 的原理：返回值 = a + Mathf.DeltaAngle * Clamp01(t),,并且内部对 t 做了限制范围是[0,1] 
 *                                                                  建议使用方式：a 和 b 在Update中都是不变的，改变的是 t，可以累加，也可以减少
 *
 *                      Mathf.MoveTowards(current,target,maxDelta)  移向
 *                                                                  原理 ：返回值 = current + maxDelta，当 返回值 > target 时，返回 target。特点：当 maxDelta 为 负数时，则反向运动，且没有限制
 *                                                                  将这个方法作为线性运动：见Update中(还有其他的做法，不过推荐这一种，因为这是官方的解释)
 *                                                                  用法:详见Update
 *                      Mathf.MoveTowardsAngle                      角度移向
 *                                                                  原理:先 计算出真正的 target = Mathf.DeltaAngle + current，然后用 Mathf.MoveTowards        
 *                                                                  用作线性变换时，与 MoveTowards 一致
 *
 *                      Mathf.SmoothDamp                            平滑阻尼（随着时间的推移逐渐改变一个值到目标值）区别与线性变换Lerp
 *                                                                  用法:详见Update
 *                      Mathf.SmoothDampAngle                       角度平滑阻尼
 *                                                                  原理：先确定真正的 target = Mathf.DeltaAngle + current 然后使用 Mathf.SmoothDamp
 *                                                                  
 *                      Mathf.SmoothStep                            平滑插值:逐渐加速，后减速
 *                                                                  用法:详见Update
 *          3、未开源类
 *              3.1、数值处理
 *                  Mathf.ClosestPowerOfTwo(value)                  返回距离value最近的2的次方数
 *                                                                  特殊1：value 自身是2的次方数，则返回 value  特殊2：若是在中间，则向上取值
 *
 *                  Mathf.IsPowerOfTwo                              判断是否是 2 的次方数
 *
 *                  Mathf.NextPowerOfTwo(value)                     返回 大于 value 的下一个 2的次方数
 *                                                                  特殊：当value自身就是 2 的次方数时，就直接返回value
 *              3.2、其他
 *                  Mathf.CorrelatedColorTemperatureToRGB           将开尔文温度转化为Color(温度的范围 1000~4000)
 *                  Mathf.PerlinNoise                               林噪声：一种伪随机的函数，每一个坐标点都可以获取确定的值，只需要取值区域不同，就可以得到类似随机的值
 *                  Mathf.GammaToLinearSpace                        todo 以下两者主要用来做颜色转换，用在shader中，以后有空再来看
 *                  Mathf.LinearToGammaSpace  
 */
using UnityEngine;

public class MathfTest : MonoBehaviour
{
    public Transform cubeLerp;
    public Transform cubeMoveToward;
    public Transform cubeSmoothDamp;
    public Transform cubeSmoothStep;


    private float speed = 0.5f; //说明是 2秒完成
    private float timer = 0;
    private float start = -5;
    private float target = 10;
    private float currentVelocity = 0;
    private float timersmoothStep = 0;
    void Update()
    {
        // Lerp 用法 
        timer += Time.deltaTime * speed;                                                            // 1/speed 秒完成线性插值，因为 Time.deltaTime 累加在1s时间中就是1，即完成线性插值
                                                                                                    // 现在 累加的速度 变成 speed 倍，那么完成时间是1秒的 1/speed 倍
        float temp = Mathf.Lerp(-5, 10, timer);                                                     // 线性插值的意思：每一段时间间隔，移动的距离应该是一样的
        cubeLerp.position = new Vector3(temp, cubeLerp.position.y, 0);
        print("temp " + temp);
        // MoveTowards 用法
        start = Mathf.MoveTowards(start, target, speed * Time.deltaTime * (10 + 5));                // 根据源码可知： 返回值 = start + maxDelta ，当 start+maxDelta > end,返回值 = target
                                                                                                    // 那么为了符合线性变化：maxDelta = 每一帧变化的值，总变化 =  target-start
                                                                                                    // 每一帧变化的值 = 总变化 * Time.deltaTime  那么就表示，1秒达到target，所以还可以增加 speed
                                                                                                    // 最后  maxDelta = (target-start)*Time.deltaTime*speed   ,那么 时间 = 1/speed
                                                                                                    // 最后 返回值需要 赋给 start ，这样就可以每帧变化相同的值，线性变化达到目标
        cubeMoveToward.position = new Vector3(start, cubeMoveToward.position.y, 0);
        print("start " + start);
        // SmoothDamp 平滑阻尼
        float x = Mathf.SmoothDamp(cubeSmoothDamp.position.x, 10, ref currentVelocity, 1 / speed);   // 根据源码可知:使用方法 current 应为不断改变的值
                                                                                                     //                     target   为目标值
                                                                                                     //                     currentVelocity 为当前速度，必须为全局变量，一开始设置为0速度即可(当然也可以设置为其他)     
                                                                                                     //                     smoothTime  阻尼运动的大致时间    
                                                                                                     //                     另外两个参数：maxSpeed deltaTime 一般默认的即可
        cubeSmoothDamp.position = new Vector3(x, cubeSmoothDamp.position.y, 0);
        print("x " + x);

        // SmoothStep 平滑插值
        timersmoothStep += speed * Time.deltaTime;
        float dex = Mathf.SmoothStep(-5, 10, timersmoothStep);                                        // 平滑插值：使用方式与 Lerp 类似 ，确定 from 和 to ,然后确定smoothTime大致时间
        cubeSmoothStep.position = new Vector3(dex, cubeSmoothStep.position.y, 0);
        print("dex " + dex);
    }



}
