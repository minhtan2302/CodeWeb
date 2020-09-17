using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    delegate bool DeKT(int num);
    class Program
    {
        static bool KiemTra(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            DeKT d = new DeKT(KiemTra);
            Console.WriteLine(d(5));
            Console.ReadKey();
            //Func<int, bool> func = new Func<int, bool>(KiemTra);
            //Console.WriteLine(func(3));
            //Console.WriteLine(func);
            //Console.ReadLine();
        }

    }
}
