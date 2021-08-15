using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles_O_Lib;

namespace SOLID_O_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Height = 1.2;
            r1.Width = 2.2;

            Rectangle r2 = new Rectangle();
            r1.Height = 4.9;
            r1.Width = 2.3;

            Circle c1 = new Circle();
            c1.Radius = 2.0;

            Shape[] shapes = { r1, r2, c1 };

            AreaCalculator ac = new AreaCalculator();
            Console.WriteLine("Total area of all shapes : " + ac.TotalArea(shapes));

            Console.ReadLine();
        }
    }
}
