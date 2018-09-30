using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStaticChange
{
    class FatherClass:IClass
    {
       
        /* 字段 */
        public static string Name = "father";
        public const string Type = "fathertype";
        public static readonly string Age = "father:50";

        /* 属性 */
        private static FatherClass _instace = null;
        private static readonly object _lockobj = new object();
        public static IClass Instance
        {
            get
            {
                if (_instace==null)
                {
                    lock(_lockobj)
                    {
                        if (_instace == null)
                        {
                            _instace = new FatherClass();
                        }
                    }
                }
                return _instace;
            }
        }
    }
}
