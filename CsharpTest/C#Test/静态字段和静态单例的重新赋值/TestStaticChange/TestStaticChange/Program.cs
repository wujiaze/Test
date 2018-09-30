using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStaticChange
{
    class Program
    {
        public static string str = "2";
        static void Main(string[] args)
        {
            Console.WriteLine(str);
            str = "33";
            Console.WriteLine(str);
            Console.WriteLine(SonClass.Name);
            Console.WriteLine(FatherClass.Name);
            Console.WriteLine(SonClass.Type);
            Console.WriteLine(FatherClass.Type);
            Console.WriteLine(SonClass.Age);
            Console.WriteLine(FatherClass.Age);
            Console.ReadLine();
        }
    }
}
