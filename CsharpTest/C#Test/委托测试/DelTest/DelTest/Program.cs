using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DelClass.MyMed(sdf,1);
            Console.Read();
        }

        private static bool sdf(int num, uint id)
        {
            Console.WriteLine(num + " / "+id);
            return true;
        }
    }
}
