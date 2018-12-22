/*
 *   介绍1：  SetParent (Transform parent, bool worldPositionStays);
 *              参数1：parent  新父物体
 *              参数2：worldPositionStays
 *              默认是true   不改变子物体的 lossyScale，通过新父物体的 localScale，改变子物体 localScale
 *               false       不改变子物体的 localScale，通过新父物体的 localScale，改变子物体 lossyScale
 *           总结：
 *               true： 子物体原来的 lossyScale = (固定参考物Canvas的lossyScale*)子物体新的 localScale * 新父物体1 localScale  * 新父物体1的父物体的 localScale * ...递归
 *                      计算公式：子物体localScale = 子物体lossyScale /  新父物体1 localScale / 新父物体1的父物体的 localScale / ...
 *                               条件：子物体的lossyScale ，在true参数时保持不变
 *              false：子物体新的 lossyScale = (固定参考物Canvas的lossyScale*) 子物体原来的 localScale * 新父物体1 localScale * 新父物体1的父物体的 localScale * ...递归
 *                      计算公式：子物体 lossyScale = 子物体 localScale  *  新父物体1 localScale * 新父物体1的父物体的 localScale * ...
 *                               条件：子物体的 localScale ，在 false 参数时保持不变
 *   介绍2：localScale 改变方式
 *          1、手动改变
 *          2、通过  SetParent 改变
 *          3、其余情况不变          
 *   介绍3: lossyScale 改变方式
 *          1、全局 lossyScale 不可手动设置
 *          2、通过改变localScale,间接改变。
 *                  近似计算公式：子物体lossyScale = (固定参考物Canvas *)子物体localScale * 父物体1 localScale * 父物体2 localScale *...递归
 *                  注意：1、父物体 localScale 改变时，不改变子物体的 localScale，只改变子物体的 lossyScale
 *                       2、子物体 lossyScale 经过上述变换数据会取近似值(比如父物体localScale=0.1125，结果为0.1)，导致失真
 *      
 *      提示:游戏对象面板上的值：都是本地坐标系的值
 *  总结： 世界坐标系下的 lossyScale = Canvas的lossyScale * 每个子物体的 localScale
 *         本地坐标系下的 localScale = 子物体lossyScale / 每个子物体的 localScale
 */
using UnityEngine;

public class ChangeUIParentScale : MonoBehaviour
{
    public RectTransform Canvas;
    public RectTransform Root;


    public RectTransform Parent1;
    public RectTransform Parent2;
    public RectTransform Son1;

    public RectTransform Parent3;
    public RectTransform Parent4;
    public RectTransform Son2;

    public RectTransform Parent5;
    public RectTransform Son3;

    void Update()
    {
        /*
         *   步骤1：测试 Canvas 和 Canvas根目录下的子物体  
         */
        if (Input.GetKeyDown(KeyCode.A))
        {
            /* 首先 Canvas的 Transform 不可更改
             * 并且 localScale  =  (1,1,1)
             *      lossyScale  =  (1,1,1)
             */
            print("Canvas的本地Scale" + Canvas.localScale);
            print("Canvas的全局Scale" + Canvas.lossyScale);


            Root.localScale = Vector3.one * 0.5f; // 手动更改自身的Scale
            print("Canvas根目录下的本地Scale" + Root.localScale);
            // lossyScale = 父物体localScale * 自身的localScale
            print("Canvas根目录下的全局Scale" + Root.lossyScale);
        }

        /*
         *  步骤2：测试 SetParent(,true)
         *        测试 父物体 localScale 改变
         */

        if (Input.GetKeyDown(KeyCode.B))
        {
            print("子物体的本地Scale" + Son1.localScale);
            print("子物体的全局Scale" + Son1.lossyScale);// 原来的全局坐标下子物体的Scale

            Parent1.localScale = Vector3.one * 0.5f;
            print("Parent1 父物体的本地Scale" + Parent1.localScale);
            print("Parent1 父物体的全局Scale" + Parent1.lossyScale);
            print("Parent2 父物体的本地Scale" + Parent2.localScale);
            print("Parent2 父物体的全局Scale" + Parent2.lossyScale);
            Son1.SetParent(Parent2);
            // 新的 localScale * 父物体 localScale = 原来的 lossyScale
            print("子物体的本地Scale" + Son1.localScale);
            // 不改变Scale世界坐标
            print("子物体的全局Scale" + Son1.lossyScale);


            // 当父物体的大小改变
            Parent1.localScale = Vector3.one * 0.1f;
            // 子物体的本地坐标不变
            print("子物体的本地Scale" + Son1.localScale);
            // 子物体的世界坐标改变
            // 新的 lossyScale = Parent1.localScale * Son1.localScale；
            print("子物体的全局Scale" + Son1.lossyScale);
        }

        /*
         *  步骤3：测试 SetPrent(,false)
         *          测试 父物体 localScale 改变
         */
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("子物体的本地Scale" + Son2.localScale);
            print("子物体的全局Scale" + Son2.lossyScale);// 原来的全局坐标下子物体的Scale

            Parent3.localScale = Vector3.one * 0.5f;
            print("Parent3 父物体的本地Scale" + Parent3.localScale);
            print("Parent3 父物体的全局Scale" + Parent3.lossyScale);
            print("Parent4 父物体的本地Scale" + Parent4.localScale);
            print("Parent4 父物体的全局Scale" + Parent4.lossyScale);
            Son2.SetParent(Parent4, false);
            print("子物体的本地Scale" + Son2.localScale);
            print("子物体的全局Scale" + Son2.lossyScale);


            // 当父物体的大小改变
            Parent3.localScale = Vector3.one * 0.1f;

            print("Parent4 父物体的本地Scale" + Parent4.localScale);
            print("Parent4 父物体的全局Scale" + Parent4.lossyScale);
            // 子物体的本地坐标不变
            print("子物体的本地Scale" + Son2.localScale);
            // 子物体的世界坐标改变
            // 新的 lossyScale = Parent1.localScale * Son1.localScale；
            print("子物体的全局Scale" + Son2.lossyScale);
        }


        /*
         *  测试父物体 为0 的特殊情况
         */

        if (Input.GetKeyDown(KeyCode.D))
        {
            /* 特殊情况*/
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale);
            Parent5.localScale = Vector3.zero;   
            print("Parent5 父物体的本地Scale" + Parent5.localScale);
            print("Parent5 父物体的全局Scale" + Parent5.lossyScale);
            Son3.SetParent(Parent5);
            // 子物体的 localScale = 1/ 父物体的localScale(0) == 导致不能除，所以产生特殊情况 子物体的 localScale(0,0,0)
            print("子物体的本地Scale" + Son3.localScale);
            // lossyScale = 1*0*0 =0
            print("子物体的全局Scale" + Son3.lossyScale); //(1,1,1)
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            /* 特殊情况*/
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale);
            Son3.SetParent(Parent5);
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale); //(1,1,1)
            Parent5.localScale = Vector3.zero;  
            print("Parent5 父物体的本地Scale" + Parent5.localScale);
            print("Parent5 父物体的全局Scale" + Parent5.lossyScale);
            
            //
            print("子物体的本地Scale" + Son3.localScale);
            // lossyScale = 1*1*0 =0
            print("子物体的全局Scale" + Son3.lossyScale); //(1,1,1)
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            /* 特殊情况*/
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale);
            Parent5.localScale = Vector3.zero;  
            print("Parent5 父物体的本地Scale" + Parent5.localScale);
            print("Parent5 父物体的全局Scale" + Parent5.lossyScale);
            Son3.SetParent(Parent5,false);
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale); 
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            /* 特殊情况*/
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale);
            Son3.SetParent(Parent5,false);
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale); 
            Parent5.localScale = Vector3.zero;  
            print("Parent5 父物体的本地Scale" + Parent5.localScale);
            print("Parent5 父物体的全局Scale" + Parent5.lossyScale);

            //
            print("子物体的本地Scale" + Son3.localScale);
            // lossyScale = 1*1*0 =0
            print("子物体的全局Scale" + Son3.lossyScale); 
        }
    }
}
