using System;
namespace TestPartial
{
    /* 测试说明：
     *         1、分部方法只能在分部类中
     *         2、分部方法的返回类型必须是 void 
     *         3、分部方法的声明和实现，既可以在同一个分部类，也可以在不同的分部类
     *         4、分部方法不能有修饰符，默认为private ，所以只能在分部类中使用
     *         5、分部方法正常使用方法重载
     *         6、分部方法不能使用out参数
     *         
     *         属性的set访问器，可以为空
     *         索引器也可以类似于方法重载，更改参数的顺序
     */
    partial class Program
    {
        partial void Pri();

        partial void Pri()
        {
        }

        partial void Ser();

        partial void Re(int ap, float p);

        partial void Re(float ap, int p);

        private int s;
        public int SH
        {
            get { return s; }
            set { }
        }


        public int this[int a, float b]
        {
            get { return s; }
            set { }
        }
        public int this[float a, int b]
        {
            get { return s; }
            set { }
        }
        static void Main(string[] args)
        {

        }
    }

    partial class Program
    {
        partial void Ser()
        {
            Pri();
        }


    }
}
