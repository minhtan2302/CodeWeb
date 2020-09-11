using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point();
            Circle C = new Circle();

            C.InCircle();
            C.OutCircle();

            P.InPoint();
            C.Check(P);
            Console.ReadKey();
        }
    }
}
