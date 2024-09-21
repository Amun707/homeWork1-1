using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    public class Circle
    {
        private double r;
        private double p;

        public Circle(double r, double p)
        {
            this.r = r;
            this.p = p;
        }
        public double LongOfCircle()
        { 
            double longOfcircle = 2 * p * r;
            return longOfcircle;
        }
        public double SquareOfCircle()
        {
            double squareOfcircle = p * r * r;
            return squareOfcircle;
        }
    }
}
