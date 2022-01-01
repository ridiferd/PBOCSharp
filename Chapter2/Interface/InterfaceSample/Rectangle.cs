using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Rectangle : IPolygon, IColor
    {
        public double CalculateArea(double a, double b)
        {
            return a*b;
        }

        public void GetColor()
        {
            Console.WriteLine("Red Color");
        }
    }

    public interface IColor
    {
        void GetColor();
    }
}