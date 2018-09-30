using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestReWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "----------------------------";
            /* 父类实例化父类 */
            
            FatherClass fc =new FatherClass(); Console.WriteLine(fc.GetType()+ str); // 实例的类型是 FatherClass  引用类型是  FatherClass
            fc.Normal();
            fc.TestVirtual();
            fc.TestAbstract();
            
            /* 子类实例化子类 */
            SonClass sc = new SonClass(); Console.WriteLine(sc.GetType() + str); // 实例的类型是 SonClass  引用类型是  SonClass
            sc.Normal();
            sc.TestVirtual();
            sc.TestAbstract();
            sc.OnlySon();
            sc.Normal("ss");
            /* 父类实例化子类 */
            FatherClass fs =new SonClass(); Console.WriteLine(fs.GetType()+ str); // 实例的类型是 SonClass  引用类型是  FatherClass
            fs.Normal();
            fs.TestVirtual();
            fs.TestAbstract();
            // 测试总结：父类的所有方法，子类不显示写出
            // 子类调用父类方法

            // 测试总结：父类的普通方法，子类中若要显示写出
            // 子类需要添加 new virtual 或者 不写 ，全部以引用类型为准，来调用方法

            // 测试总结：父类的虚方法，子类中若要显示写出
            // 子类 方法1 ： new virtual 或者 不写，则根据 引用类型   来调用方法
            //      方法2： override ，            则根据 实例化类型 来调用方法

            // 测试总结：父类的抽象方法(父类从爷爷类继承来的)，即 override 修饰的方法，当然还包括其余情况不止抽象方法一种
            // 子类 方法1： new virtual 或者 不写，则根据 引用类型   来调用方法
            //       方法2： override ，            则根据 实例化类型 来调用方法

            /*--------------------最后结论--------------------------*/
            // 测试总结：
            // 只有override重写的方法，是根据实例化类型来调用，其余都是以引用类型来调用
            // 当引用类型和实例化类型一致时，就调用各自的引用类型，这一条没什么好讨论的
            // 子类独有的方法(普通方法，虚方法，父类方法的重载方法)，只有引用类型是 子类才能够调用

            /* 子类实例化父类*/
            // 下面的强制转换是错误的
            //SonClass sf = (SonClass)new FatherClass();

            Console.ReadLine();
        }
    }
}
