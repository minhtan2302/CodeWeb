using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            HCN hcn = new HCN();
            hcn.CongThuc();
            Console.WriteLine("Chu vi hinh chu nhat la :" + hcn.ChuViHCN());
            Console.WriteLine("Dien tich hinh chu nhat la :" + hcn.DienTichHCN());
            Console.ReadLine();

            //HCN.CongThuc();
            //Console.WriteLine("Chu vi hinh chu nhat la :" + ChuViHCN());
            //Console.WriteLine("Dien tich hinh chu nhat la :" + DienTichHCN());
            //Console.ReadLine();

            //Point p1 = new Point(3, 4);
            //Point p2 = new Point(5, 7);
            //double distance = p1.DistanceTo(p2);

        }
    }
}
