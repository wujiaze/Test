using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConstruct
{
    public class FatherClass
    {
        /* 单例 */
        private static FatherClass _instance;
        private static readonly object _lockobj =new object();
        public static FatherClass Instance {
            get
            {
                if (_instance==null)
                {
                    lock (_lockobj)
                    {
                        if (_instance == null)
                        {
                            _instance =new FatherClass();
                        }
                    }
                }
                return _instance;
            }
        }

        /* 构造函数 */
        protected FatherClass()
        {
            Console.WriteLine("父类的构造函数语句");
        }
        protected  FatherClass(string name)
        {
            Console.WriteLine("父类的构造函数语句"+name);
        }

        static FatherClass()
        {
            Console.WriteLine("父类的静态构造函数");
        }



        /* 方法 */
        public virtual void Show()
        {
            Console.WriteLine("父类虚方法");
        }

        public virtual void Over()
        {
            Console.WriteLine("父类的虚方法OVER");
        }
    }
}
