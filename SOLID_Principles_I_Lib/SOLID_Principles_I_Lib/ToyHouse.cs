using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_I_Lib
{
    public interface IToy
    {
        void SetPrice(double price);
        void SetColor(String color);
        //void Move();
        //void Fly();
    }

    public interface IMove
    {
        //void Move();
        //void Fly();
    }
    class ToyHouse : IToy
    {
        double price;
        String color;

        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void SetColor(String color)
        {
            this.color = color;
        }
        //public void Move()
        //{
        //    throw new Exception("Not allowed");
        //}
        //public void Fly()
        //{
        //    throw new Exception("Not allowed");
        //}
    }

    class AirPlane : IToy, IMove
    {
        double price;
        String color;

        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void SetColor(String color)
        {
            this.color = color;
        }

        public void Move()
        {
            //move
        }
        public void Fly()
        {
            //fly
        }

    }
}
