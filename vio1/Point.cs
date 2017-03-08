using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vio1
{
    class Point
    {
        public int Column { get; set; }
        public int Row { get; set; }

        public Point(int x, int y)
        {
            this.Column = x;
            this.Row = y;
        }
    }
}
