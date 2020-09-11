using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Point
    {
        private int Ox { get; set; }
        private int Oy { get; set; }
        public Point()
        {
        
        }
        public Point()
        {
            this.Ox = Ox;
            this.Oy = Oy;
        }
        public void Input()
        {
            Console.WriteLine("Nhap toa do: ");
            Console.Write("X: ");
            Ox = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y; ");
            Oy = Convert.ToInt32(Console.ReadLine());
        } 
        public double DistanceTo(Point a)
        {
            Double result = Math.Sqrt((Math.Pow(a.Ox-Ox,2)) + Math.Pow(a.Oy-Oy,2)));
            return result;
        }
        static void Point(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Point A = new Point(2, 3);
            Point B = new Point(4, 5);
            Point C = new Point();
            Point D = new Point();
            C.Input();
            D.Input();
            Console.WriteLine($"Khoảng cach từ điểm C({C.Ox},{C.Oy})  đến điểm  D({D.Ox},{D.Oy})  =  " + C.Distance(D));


        }
    }
}
