using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTPoint
{
        class Point
        {

            public int Ox { set; get; }
            public int Oy { set; get; }
            public Point()
            {

            }
            public Point(int Ox, int Oy)
            {
                this.Ox = Ox;
                this.Oy = Oy;
            }
            public void InPoint()
            {
                Console.WriteLine("Nhap Diem :");
                Console.Write("X:");
                Ox = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y:");
                Oy = Convert.ToInt32(Console.ReadLine());

            }
        }
        class Circle : Point
        {
            public Point Center { get; set; }
            public int Radius { get; set; }

            public Circle()
            {
                Center = new Point(0, 0);
                Radius = 1;
            }

            public Circle(Point Center, int Radius)
            {
                this.Center = Center;
                this.Radius = Radius;
            }
            public void InCircle()
            {
                Console.WriteLine("Nhap Toa Đo Tam Cua Circle: ");
                Console.Write("X:");
                Center.Ox = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y:");
                Center.Oy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ban Kinh:");
                Radius = Convert.ToInt32(Console.ReadLine());
            }
            public void OutCircle()
            {
                Console.WriteLine("Tam Cua Circle:");
                Console.WriteLine("x={0},y={1}", Center.Ox, Center.Oy);
                Console.WriteLine("Ban Kinh Cua Circle: {0}", Radius);

            }
            public enum ViTri
            {
                Trong, Tren, Ngoai
            }
            public void Check(Point another)
            {
                double result = Math.Sqrt((Math.Pow(another.Ox - Center.Ox, 2)) + (Math.Pow(another.Oy - Center.Oy, 2)));
                if (Radius == result)
                {

                    Console.WriteLine("Diem Nam Ben {0} Hinh Tron", ViTri.Tren);
                }
                else if (Radius > result)
                {
                    Console.WriteLine("Diem Nam Ben {0} Hinh Tron", ViTri.Trong);
                }
                else
                {
                    Console.WriteLine("Diem Nam Ben {0} Hinh Tron", ViTri.Ngoai);
                }
            }


        }



  }
