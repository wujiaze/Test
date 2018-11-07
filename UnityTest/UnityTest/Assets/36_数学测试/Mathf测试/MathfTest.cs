/*
 *      Mathf 类解析
 *
 *      从角度转到弧度的常数
 *          Mathf.Deg2Rad
 *      从弧度转到角度的常数
 *          Mathf.Rad2Deg
 *
 *      区别于 0 的最小浮点数
 *          Mathf.Epsilon
 *
 *      正无穷大
 *          Mathf.Infinity
 *      负无穷大
 *          Mathf.NegativeInfinity
 *
 *      圆周率 π 的值
 *          Mathf.PI
 *
 *      绝对值
 *          Mathf.Abs()
 *
 *      浮点数比较
 *          Mathf.Approximately    // 浮点数的比较其实都是不精准的，可以采用近似来比较，这个方法的精度大概在 E-45，是非常高的精确度了
 *
 *      向上取整(返回 float)
 *          Mathf.Ceil
 *      向上取整(返回 int)
 *          Mathf.CeilToInt
 *
 *      限制取值范围
 *      Mathf.Clamp
 *      Mathf.Clamp01  特殊：min=0 max=1
 *
 *      返回距离value最近的2的次方数，若 value 自身是2的次方数，则返回 value
 *      Mathf.ClosestPowerOfTwo(value)   // 若是在中间，则向上取值
 *      判断是否是 2 的次方数
 *      Mathf.IsPowerOfTwo
 *      返回 大于 value 的下一个 2的次方数，当value自身就是 2 的次方数时，就直接返回value
 *       Mathf.NextPowerOfTwo(value)
 *  
 *      将开尔文温度转化为Color(温度的范围 1000~4000)
 *          Mathf.CorrelatedColorTemperatureToRGB
 *
 *      获取两个角的最小夹角，范围在(-180,180]
 *          Mathf.DeltaAngle
 *
 *      自然指数 e 的n次方数
 *          Mathf.Exp
 *
 *      向下取整(返回 float)
 *          Mathf.Floor
 *      向下取整(返回 int)
 *          Mathf.FloorToInt
 *
 *      取对数
 *      Mathf.Log   f：值  p: 对数的底(默认为 自然指数 e)
 *      Mathf.Log10  f:值  对数的底为10
 *
 *      最大值
 *      Mathf.Max  在一个float 或 int  的数组中，获取最大值
 *      最小值
 *      Mathf.Min  在一个float 或 int  的数组中，获取最小值
 *
 *      三角函数：
 *      Mathf.Acos()
 *      Mathf.Asin()
 *      Mathf.Atan()
 *      Mathf.Atan2()
 *      Mathf.Cos()
 *
 *      周期性重复
 *      Mathf.Repeat(t,length)      每当 t 大于等于 length ，就返回 t % length
 *
 *      柏林噪声
 *      Mathf.PerlinNoise   柏林噪声：一种伪随机的函数，每一个坐标点都可以获取确定的值，只需要取值区域不同，就可以得到类似随机的值
 *
 *      插值类
 *      线性插值
 *      Mathf.Lerp          计算方式 (end-start)*t+start 
 *                          正确用法是：start 和 end 在Update中都是不变的，改变的一致是 t ,t 的在内部的限制范围是[0,1]
 *      Mathf.LerpUnclamped 与Lerp一致，不同点：对t没有限制
 *
 *      角度线性插值(原理和Lerp一样，只是内部对180和大于180的数值做了处理)
 *      Mathf.LerpAngle     首先计算角度： 把需要变化的角度都转换为(-180,180]
 *                          然后就是 Lerp 的计算方法，t的有效范围是[0,1]
 *
 *      反插值 : 计算两个值之间的Lerp参数
 *      Mathf.InverseLerp   计算方式 （value - from）/（to - from）,返回值[0,1]
 *
 *      Move 类
 *      Mathf.MoveTowards  本质上也是一种线性插值，优点是：不会超过 target
 *                         如何使用：见Update中(还有其他的做法，不过推荐这一种，因为这是官方的解释)
 *                         特点：当 maxDelta 为 负数时，则反向运动，且没有限制
 *      Mathf.MoveTowardsAngle  源码为:先通过 Mathf.DeltaAngle 计算出 真正的target，然后用 Mathf.MoveTowards
 *
 */
using UnityEngine;

public class MathfTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        print(Mathf.ClosestPowerOfTwo(8));
    }

    private float timer = 0;
    private float start = 5;
    private float target = 10;
    void Update()
    {
        timer += 0.5f * Time.deltaTime;                // 2 可以是看作 1/2 秒完成线性插值，因为 Time.deltaTime 累加在1s时间中就是1，即完成线性插值
                                                       // 现在 累加的速度 变成 2倍，那么完成时间就减少一倍，是1秒的 1/2 倍，即0.5秒
        float temp = Mathf.Lerp(5, 10, timer);      // 线性插值的意思：每一段时间间隔，移动的距离应该是一样的
        //print("temp " + temp);
        //float angle = Mathf.LerpAngle(0, 359, timer);
        //print("angle " + angle);


        start = Mathf.MoveTowards(start, target, 2 * Time.deltaTime * (10 - 5));
        //print("move " + start);                     // 根据源码可知： 返回值 = start + maxDelta ，当 start+maxDelta > end,返回值 = target
        // 那么为了符合线性变化：maxDelta = 每一帧变化的值，总变化 =  target-start
        // 每一帧变化的值 = 总变化 * Time.deltaTime  那么就表示，1秒达到target，所以还可以增加 speed
        // 最后  maxDelta = (target-start)*Time.deltaTime*speed   ,那么 时间 = 1/speed
        // 最后 返回值需要 赋给 start ，这样就可以每帧变化相同的值，线性变化达到目标
        //Mathf.MoveTowardsAngle()

        print(Mathf.PerlinNoise(10, 10));

      
    }

    private void Awake()
    {

    }


}
