using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VecRotateTest : MonoBehaviour
{


    private Vector3 vec1;
    private Vector3 vec2;
    private Vector3 vec3;
    void Start()
    {
        vec1 = Vector3.left;
        vec2 = new Vector3(1, 1, 0);
        vec3 = Vector3.right;
        /* Vector3.Angle 总结
         *  1、两个不同的向量，夹角永远取小与等于180度的那个，跟参数位置无关
         *  2、夹角范围[0,180]
         *  3、两个相同的向量，夹角 等于0
         *  4、任何向量和零向量的夹角，在Unity中为90度
         */
        float angle1 = Vector3.Angle(Vector3.left, new Vector3(1, 1, 0));                   // 135 度     
        float angle2 = Vector3.Angle(new Vector3(1, 1, 0), Vector3.left);                   // 135 度     
        float angle3 = Vector3.Angle(Vector3.left, Vector3.right);                   // 180 度    
        float angle4 = Vector3.Angle(Vector3.right, Vector3.left);                   // 180 度
        float angle5 = Vector3.Angle(Vector3.left, Vector3.left);                   // 0   度     
        float angle6 = Vector3.Angle(Vector3.zero, Vector3.zero);   // 90  度     
        float angle7 = Vector3.Angle(vec1, Vector3.zero);           // 90  度
        float angle8 = Vector3.Angle(Vector3.zero, Vector3.left);           // 90  度
        print("angle1----     " + angle1);
        print("angle2----     " + angle2);
        print("angle3----     " + angle3);
        print("angle4----     " + angle4);
        print("angle5----     " + angle5);
        print("angle6----     " + angle6);
        print("angle7----     " + angle7);
        print("angle8----     " + angle8);
        /* Vector3.Cross（from，to） 总结
         *   1、方向判断：符合左手定则
         *   左手的四指从from，（以小于180度）弯曲向to，大拇指的方向就是叉向量的方向
         *   2、向量的夹角为0或180度时，因为左手可以任意弯曲，所以不存在叉向量
         *   3、零向量和任何向量都没有叉向量
         *   4、叉向量只有三维的才有（二维向量需要进行转换）
         */

        Vector3 cro1 = Vector3.Cross(Vector3.left, new Vector3(1, 1, 0));   // (0,0,-1)  左手定则，大拇指 指向人侧
        Vector3 cro2 = Vector3.Cross(new Vector3(1, 1, 0), Vector3.left);   // (0,0,1)  左手定则，大拇指 指向外侧
        Vector3 cro3 = Vector3.Cross(Vector3.left, Vector3.left);   // (0,0,0)  没有方向
        Vector3 cro4 = Vector3.Cross(Vector3.left, Vector3.right);   // (0,0,0)  没有方向
        Vector3 cro5 = Vector3.Cross(Vector3.right, Vector3.left);   // (0,0,0)  没有方向
        Vector3 cro6 = Vector3.Cross(Vector3.left, Vector3.zero);   // (0,0,0)  没有方向
        Vector3 cro7 = Vector3.Cross(Vector3.zero, Vector3.left);   // (0,0,0)  没有方向
        Vector3 cro8 = Vector3.Cross(Vector3.zero, Vector3.zero); // (0,0,0)没有方向
        print("cro1   " + cro1);
        print("cro2   " + cro2);
        print("cro3   " + cro3);
        print("cro4   " + cro4);
        print("cro5   " + cro5);
        print("cro6   " + cro6);
        print("cro7   " + cro7);
        print("cro8   " + cro8);

        /* 旋转 四元数
         *   向量采用四元数进行旋转的公式：四元数*向量（顺序不能反）
         *   规则：满足左手法则
         *        角度的正负：代表旋转轴的方向，也就是左手大拇指的方向，正代表向外，负代表向内
         *        角度的旋转方向：逆时针旋转
         *   简化规则 ==>  逆时针旋转 设置的度数，负数就顺时针旋转
         *
         */
        Vector3 fin0 = Quaternion.Euler(new Vector3(0, 0, 90)) * Vector2.left;
        print("fin0   " + fin0);
        Vector3 fin1 = Quaternion.Euler(new Vector3(0, 90, 0)) * Vector2.left;
        print("fin1   " + fin1);
        Vector3 fin2 = Quaternion.Euler(new Vector3(90, 0, 0)) * Vector2.left;
        print("fin2   " + fin2);


        print("------------");
        print(Vector3.zero.normalized);
    }

}
