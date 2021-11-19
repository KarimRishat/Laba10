using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figure
{
    class Circle:Point
    {
        double rad;
        public Circle()
            :base()
        {
            rad = 0;
        }
        public Circle(double rad, int x, int y, Color color, Status status)
            :base(x,y,color,status)
        {
            this.rad = rad;
        }
        public double Square(double rad)
        {
            return rad * rad * Math.PI;
        }
    }
}
