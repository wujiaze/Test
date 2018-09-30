using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承测试
{
    class Program
    {
        // 测试说明:公共字段，在继承时，子类 会 new 一个新对象
        // 测试说明:私有字段，在继承时，子类也会 new 一个新对象
        static void Main(string[] args)
        {
            FatherClass fc =new FatherClass();
            SonClass sc = new SonClass();
            fc.add();
            //fc.show();
            sc.show();
            Console.WriteLine("-----------------------");

            sc.AddPri(1);
            //sc.Showrilist();
            fc.Showrilist();

            Console.Read();
        }
    }
}
