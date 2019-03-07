/*
 *  前提： 相对坐标和绝对坐标之间的转换  绝对坐标 = 参考值*相对坐标
 *                                    相对坐标 = 参考值/相对坐标
 *  Scale
 *      两个概念
 *          localScale
 *              1、localScale      直接改变
 *              2、SetParent(true) 间接改变         
 *          lossyScale
 *              1、任何一个对象的默认初始为 1
 *              2、通过改变 localScale 间接改变
 *      一个计算公式
 *          自身当前 lossyScale = 默认初始值1 * 自身localScale * 父物体1 localScale * 父物体2 localScale ...
 *              注意：1、每一次物体的改变(比如：生成、改变父物体)，都会计算一遍整个式子
 *                    2、这个方法会导致失真，比如：某一父物体localScale=0.1125，但被近似为0.1，导致最后结果失真
 *      一个面板显示
 *          属性面板上看到的 Scale 都是 localScale
 *
 *
 *
 *   SetParent (Transform parent, bool worldPositionStays);
 *              参数1：parent  新父物体
 *              参数2：worldPositionStays
 *                      true(默认)  不改变方法执行前子物体的 lossyScale
 *                      false       不改变方法执行前子物体的 localScale
 *              具体分析：
 *                          子物体执行前的 lossyScaleA = 默认初始值1 * 子物体执行前的 localScaleA * 父物体 localScaleA  * 父物体的父物体 localScaleA...
 *                          子物体执行后的 lossyScaleB = 默认初始值1 * 子物体执行后的 localScaleB * 新父物体 localScaleB  * 新父物体的父物体 localScaleB...
 *                  true：  执行后的 lossyScaleB = 执行前的 lossyScaleA
 *                          求得：子物体执行后的 localScaleB = 子物体执行前的 lossyScaleA /  新父物体 localScaleB / 新父物体的父物体 localScaleB / ...
 *                  false： 执行后的 localScaleB = 执行前的 localScaleA
 *                          求得：子物体执行后的 lossyScaleB = 默认初始值1 * 执行前的 localScaleA  *  新父物体 localScaleB * 新父物体的父物体 localScaleB ...
 *
 *              特殊情况：当某个父物体 localScale = 0 
 *                          true :  localScale = 0
 *                                  lossyScale = 0（看不到了）
 *                          false:  localScale = 原来的scale
 *                                  lossyScale = 0（看不到了）
 *                      解决方法:
 *                              1、针对第二次SetParent后，物体需要时原来的样子，那么可以是第一次采用 false ，第二次也采用false
 *              总结： lossyScale = 默认值1 * 每个子物体的 localScale
 *                    localScale = 默认值1  / 每个子物体的 localScale
 *  
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
            Son3.SetParent(Parent5, false);
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            /* 特殊情况*/
            print("子物体的本地Scale" + Son3.localScale);
            print("子物体的全局Scale" + Son3.lossyScale);
            Son3.SetParent(Parent5, false);
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
