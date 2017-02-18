using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Point
    {
        public double x             //or int?
        {
            get { return x; }
            set { if (value > 0 && value < 1024) x = value; }
        }

        public double y             //or int?
        {
            get { return y; }
            set { if (value > 0 && value < 768) y = value; }
        }

        public Point(double x_val, double y_val) //constructor 1
        {
            this.x = x_val;
            this.y = y_val;
        }

        public Point() // constructor 2 (по умолчанию)
        {
            this.x = 1;
            this.y = 1;
        }
    }
}
