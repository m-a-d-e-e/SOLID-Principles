using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_L_Lib
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double GetArea()
        {
            return Height * Width;
        }
    }

    //public class Square : Rectangle    //class square does not require 2 separate dimensions  //even though they Square has a 'is a' relationship with Rectangle
    //{
    //    public override double GetArea()
    //    {
    //        return Height*Width ;
    //    }
    //}


    public class Square : Shape
    {
        public double Dimension { get; set; }

        public override double GetArea()
        {
            return Dimension * Dimension;
        }

    }

}
