using System;
using System.Collections.Generic;
using System.Text;

namespace LineComp
{
    class Points
    {
        int x1, y1, x2, y2;
        double length;

        public Points(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double calLength()
        {
            length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            return length;
        }
    }
}
