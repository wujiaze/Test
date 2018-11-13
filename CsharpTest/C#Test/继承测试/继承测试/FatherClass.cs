using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承测试
{
    class FatherClass:BaseClass
    {
        public List<int> publist=new List<int>(); // 测试说明:公共字段，在继承时，子类 会 new 一个新对象

        public FatherClass()
        {
            
        }
        public override void Start()
        {
            Console.WriteLine("111");
        }

        public void add()
        {
            publist.Add(1);
        }
        public void show()
        {
            Console.WriteLine(publist.Count);
        }

        private List<int> priList = new List<int>();  // 测试说明:私有字段，在继承时，子类也会 new 一个新对象

        public void AddPri(int x)
        {
            Console.WriteLine(priList);
            priList.Add(x);
        }

        public void Showrilist()
        {
            Console.WriteLine(priList.Count);
        }
    }
}
