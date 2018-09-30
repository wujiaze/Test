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

        float angle1 = Vector3.Angle(vec1, vec2);                   // 135 度     两个不同的向量，夹角永远取小与等于180度的那个，跟参数位置无关
        float angle2 = Vector3.Angle(vec2, vec1);                   // 135 度     
        float angle3 = Vector3.Angle(vec1, vec3);                   // 180 度    
        float angle4 = Vector3.Angle(vec3, vec1);                   // 180 度
        float angle5 = Vector3.Angle(vec1, vec1);                   // 0   度     两个相同的向量，夹角 等于0
        float angle6 = Vector3.Angle(Vector3.zero, Vector3.zero);   // 90  度     任何向量和零向量的夹角，在Unity中等于 90 度
        float angle7 = Vector3.Angle(vec1, Vector3.zero);           // 90  度
        float angle8 = Vector3.Angle(Vector3.zero, vec1);           // 90  度
        print(angle1);
        print(angle2);
        print(angle3);
        print(angle4);
        print("angle5----     " + angle5);
        print("angle6----     " + angle6);
        print("angle7----     " + angle7);
        print("angle8----     " + angle8);
        /* 叉向量的方向 */
        Vector3 cro1 = Vector3.Cross(vec1, vec2);   // (0,0,-1)  左手定则，大拇指 指向人侧
        Vector3 cro2 = Vector3.Cross(vec2, vec1);   // (0,0,1)  左手定则，大拇指 指向外侧
        Vector3 cro3 = Vector3.Cross(vec1, vec1);   // (0,0,0)  没有方向
        Vector3 cro4 = Vector3.Cross(vec1, vec3);   // (0,0,0)  没有方向
        Vector3 cro5 = Vector3.Cross(vec3, vec1);   // (0,0,0)  没有方向
        Vector3 cro6 = Vector3.Cross(vec1, Vector3.zero);   // (0,0,0)  没有方向
        Vector3 cro7 = Vector3.Cross(Vector3.zero, vec1);   // (0,0,0)  没有方向
        Vector3 cro8 = Vector3.Cross(Vector3.zero, Vector3.zero); // (0,0,0)没有方向
        print(cro1);
        print(cro2);
        print(cro3);
        print("cro4   " + cro4);
        print("cro5   " + cro5);
        print("cro6   " + cro6);
        print("cro7   " + cro7);
        print("cro8   " + cro8);

        /* 旋转 四元数*向量 */
        /* 二维 */
        Vector2 fin0 = Quaternion.Euler(new Vector2(0, 0)) * Vector2.left;      //(-1,0)
        Vector2 fin1 = Quaternion.Euler(new Vector2(1, 0)) * Vector2.left;
        Vector2 fin2 = Quaternion.Euler(new Vector2(1, 1)) * Vector2.left;
        Vector2 fin3 = Quaternion.Euler(new Vector2(0, 1)) * Vector2.left;
        Vector2 fin4 = Quaternion.Euler(new Vector2(-1, 1)) * Vector2.left;
        Vector2 fin5 = Quaternion.Euler(new Vector2(-1, 0)) * Vector2.left;
        Vector2 fin6 = Quaternion.Euler(new Vector2(-1, -1)) * Vector2.left;
        Vector2 fin7 = Quaternion.Euler(new Vector2(0, -1)) * Vector2.left;
        Vector2 fin8 = Quaternion.Euler(new Vector2(1, -1)) * Vector2.left;
        print("fin0   " + fin0);
        print("fin1   " + fin1);
        print("fin2   " + fin2);
        print("fin3   " + fin3);
        print("fin4   " + fin4);
        print("fin5   " + fin5);
        print("fin6   " + fin6);
        print("fin7   " + fin7);
        print("fin8   " + fin8);

        Vector2 fin00 = Quaternion.Euler(new Vector2(0, 0)) * Vector3.left;  //(-1,0)
        Vector2 fin10 = Quaternion.Euler(new Vector2(1, 0)) * Vector3.left;
        Vector2 fin20 = Quaternion.Euler(new Vector2(1, 1)) * Vector3.left;
        Vector2 fin30 = Quaternion.Euler(new Vector2(0, 1)) * Vector3.left;
        Vector2 fin40 = Quaternion.Euler(new Vector2(-1, 1)) * Vector3.left;
        Vector2 fin50 = Quaternion.Euler(new Vector2(-1, 0)) * Vector3.left;
        Vector2 fin60 = Quaternion.Euler(new Vector2(-1, -1)) * Vector3.left;
        Vector2 fin70 = Quaternion.Euler(new Vector2(0, -1)) * Vector3.left;
        Vector2 fin80 = Quaternion.Euler(new Vector2(1, -1)) * Vector3.left;
        print("fin00   " + fin00);
        print("fin10   " + fin10);
        print("fin20   " + fin20);
        print("fin30   " + fin30);
        print("fin40   " + fin40);
        print("fin50   " + fin50);
        print("fin60   " + fin60);
        print("fin70   " + fin70);
        print("fin80   " + fin80);

        Vector3 fin000 = Quaternion.Euler(new Vector2(0, 0)) * Vector2.left;  //(-1,0,0)
        Vector3 fin100 = Quaternion.Euler(new Vector2(1, 0)) * Vector2.left;
        Vector3 fin200 = Quaternion.Euler(new Vector2(1, 1)) * Vector2.left;
        Vector3 fin300 = Quaternion.Euler(new Vector2(0, 1)) * Vector2.left;
        Vector3 fin400 = Quaternion.Euler(new Vector2(-1, 1)) * Vector2.left;
        Vector3 fin500 = Quaternion.Euler(new Vector2(-1, 0)) * Vector2.left;
        Vector3 fin600 = Quaternion.Euler(new Vector2(-1, -1)) * Vector2.left;
        Vector3 fin700 = Quaternion.Euler(new Vector2(0, -1)) * Vector2.left;
        Vector3 fin800 = Quaternion.Euler(new Vector2(1, -1)) * Vector2.left;
        print("fin000   " + fin000);
        print("fin100   " + fin100);
        print("fin200   " + fin200);
        print("fin300  " + fin300);
        print("fin400   " + fin400);
        print("fin500   " + fin500);
        print("fin600   " + fin600);
        print("fin700   " + fin700);
        print("fin800   " + fin800);

        Vector2 fin01 = Quaternion.Euler(new Vector3(0, 0, 0)) * Vector2.left;      //(-1,0)
        Vector2 fin11 = Quaternion.Euler(new Vector3(1, 0, 0)) * Vector2.left;
        Vector2 fin21 = Quaternion.Euler(new Vector3(1, 1, 0)) * Vector2.left;
        Vector2 fin31 = Quaternion.Euler(new Vector3(0, 1, 0)) * Vector2.left;
        Vector2 fin41 = Quaternion.Euler(new Vector3(-1, 1, 0)) * Vector2.left;
        Vector2 fin51 = Quaternion.Euler(new Vector3(-1, 0, 0)) * Vector2.left;
        Vector2 fin61 = Quaternion.Euler(new Vector3(-1, -1, 0)) * Vector2.left;
        Vector2 fin71 = Quaternion.Euler(new Vector3(0, -1, 0)) * Vector2.left;
        Vector2 fin81 = Quaternion.Euler(new Vector3(1, -1, 0)) * Vector2.left;
        print("fin01   " + fin01);
        print("fin11   " + fin11);
        print("fin21   " + fin21);
        print("fin31   " + fin31);
        print("fin41   " + fin41);
        print("fin51   " + fin51);
        print("fin61   " + fin61);
        print("fin71   " + fin71);
        print("fin81   " + fin81);


        Vector2 fin02 = Quaternion.Euler(new Vector3(0, 0, 0)) * Vector3.left;      //(-1,0)
        Vector2 fin12 = Quaternion.Euler(new Vector3(1, 0, 0)) * Vector3.left;
        Vector2 fin22 = Quaternion.Euler(new Vector3(1, 1, 0)) * Vector3.left;
        Vector2 fin32 = Quaternion.Euler(new Vector3(0, 1, 0)) * Vector3.left;
        Vector2 fin42 = Quaternion.Euler(new Vector3(-1, 1, 0)) * Vector3.left;
        Vector2 fin52 = Quaternion.Euler(new Vector3(-1, 0, 0)) * Vector3.left;
        Vector2 fin62 = Quaternion.Euler(new Vector3(-1, -1, 0)) * Vector3.left;
        Vector2 fin72 = Quaternion.Euler(new Vector3(0, -1, 0)) * Vector3.left;
        Vector2 fin82 = Quaternion.Euler(new Vector3(1, -1, 0)) * Vector3.left;
        print("fin02   " + fin02);
        print("fin12   " + fin12);
        print("fin22   " + fin22);
        print("fin32   " + fin32);
        print("fin42   " + fin42);
        print("fin52   " + fin52);
        print("fin62   " + fin62);
        print("fin72   " + fin72);
        print("fin82   " + fin82);



        Vector3 fin03 = Quaternion.Euler(new Vector2(0, 0)) * Vector3.left;  //(-1,0,0)
        Vector3 fin13 = Quaternion.Euler(new Vector2(1, 0)) * Vector3.left;
        Vector3 fin23 = Quaternion.Euler(new Vector2(1, 1)) * Vector3.left;
        Vector3 fin33 = Quaternion.Euler(new Vector2(0, 1)) * Vector3.left;
        Vector3 fin43 = Quaternion.Euler(new Vector2(-1, 1)) * Vector3.left;
        Vector3 fin53 = Quaternion.Euler(new Vector2(-1, 0)) * Vector3.left;
        Vector3 fin63 = Quaternion.Euler(new Vector2(-1, -1)) * Vector3.left;
        Vector3 fin73 = Quaternion.Euler(new Vector2(0, -1)) * Vector3.left;
        Vector3 fin83 = Quaternion.Euler(new Vector2(1, -1)) * Vector3.left;
        print("fin03   " + fin03);
        print("fin13   " + fin13);
        print("fin23   " + fin23);
        print("fin33   " + fin33);
        print("fin43   " + fin43);
        print("fin53   " + fin53);
        print("fin63   " + fin63);
        print("fin73   " + fin73);
        print("fin83   " + fin83);


        Vector3 fin04 = Quaternion.Euler(new Vector3(0, 0, 0)) * Vector2.left;      //(-1,0,0)
        Vector3 fin14 = Quaternion.Euler(new Vector3(1, 0, 0)) * Vector2.left;
        Vector3 fin24 = Quaternion.Euler(new Vector3(1, 1, 0)) * Vector2.left;
        Vector3 fin34 = Quaternion.Euler(new Vector3(0, 1, 0)) * Vector2.left;
        Vector3 fin44 = Quaternion.Euler(new Vector3(-1, 1, 0)) * Vector2.left;
        Vector3 fin54 = Quaternion.Euler(new Vector3(-1, 0, 0)) * Vector2.left;
        Vector3 fin64 = Quaternion.Euler(new Vector3(-1, -1, 0)) * Vector2.left;
        Vector3 fin74 = Quaternion.Euler(new Vector3(0, -1, 0)) * Vector2.left;
        Vector3 fin84 = Quaternion.Euler(new Vector3(1, -1, 0)) * Vector2.left;
        print("fin04   " + fin04);
        print("fin14   " + fin14);
        print("fin24   " + fin24);
        print("fin34   " + fin34);
        print("fin44   " + fin44);
        print("fin54   " + fin54);
        print("fin64   " + fin64);
        print("fin74   " + fin74);
        print("fin84   " + fin84);

        Vector3 fin05 = Quaternion.Euler(new Vector3(0, 0, 0)) * Vector3.left;      //(-1,0,0)
        Vector3 fin15 = Quaternion.Euler(new Vector3(1, 0, 0)) * Vector3.left;
        Vector3 fin25 = Quaternion.Euler(new Vector3(1, 1, 0)) * Vector3.left;
        Vector3 fin35 = Quaternion.Euler(new Vector3(0, 1, 0)) * Vector3.left;
        Vector3 fin45 = Quaternion.Euler(new Vector3(-1, 1, 0)) * Vector3.left;
        Vector3 fin55 = Quaternion.Euler(new Vector3(-1, 0, 0)) * Vector3.left;
        Vector3 fin65 = Quaternion.Euler(new Vector3(-1, -1, 0)) * Vector3.left;
        Vector3 fin75 = Quaternion.Euler(new Vector3(0, -1, 0)) * Vector3.left;
        Vector3 fin85 = Quaternion.Euler(new Vector3(1, -1, 0)) * Vector3.left;
        print("fin05   " + fin05);
        print("fin15   " + fin15);
        print("fin25   " + fin25);
        print("fin35   " + fin35);
        print("fin45   " + fin45);
        print("fin55   " + fin55);
        print("fin65   " + fin65);
        print("fin75   " + fin75);
        print("fin85   " + fin85);


        Vector2 fin06 = Quaternion.Euler(new Vector3(0, 0, 270)) * Vector2.left;
        print("fin06   " + fin06);


        Vector2 fin07 = Quaternion.Euler(new Vector3(0, 0, -1)) * Vector2.left;
        print("fin07   " + fin07);
        //Vector2 fin01 = Quaternion.Euler(new Vector3(0, 0, 0)) * Vector2.left;      //(-1,0)
        //Vector2 fin11 = Quaternion.Euler(new Vector3(1, 0, 0)) * Vector2.left;
        //Vector2 fin21 = Quaternion.Euler(new Vector3(1, 1, 0)) * Vector2.left;
        //Vector2 fin31 = Quaternion.Euler(new Vector3(0, 1, 0)) * Vector2.left;
        //Vector2 fin41 = Quaternion.Euler(new Vector3(-1, 1, 0)) * Vector2.left;
        //Vector2 fin51 = Quaternion.Euler(new Vector3(-1, 0, 0)) * Vector2.left;
        //Vector2 fin61 = Quaternion.Euler(new Vector3(-1, -1, 0)) * Vector2.left;
        //Vector2 fin71 = Quaternion.Euler(new Vector3(0, -1, 0)) * Vector2.left;
        //Vector2 fin81 = Quaternion.Euler(new Vector3(1, -1, 0)) * Vector2.left;

        //print("fin11   " + fin11);


        Vector3 v = Vector3.Lerp(Vector3.up, Vector3.up, Time.deltaTime);  // 结果 Vector3.up
        print("v  " + v);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
