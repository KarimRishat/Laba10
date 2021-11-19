using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figure
{
    class Point:Figure
    {
        int x;
        int y;
        public Point()
            :base()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y,Color color, Status status)
            :base(color,status)
        {
            this.x = x;
            this.y = y;
        }
        
    }
}
