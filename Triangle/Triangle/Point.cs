using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x_val, double y_val) 
        {
            this.X = x_val;
            this.Y = y_val;
        }

        public static bool operator ==(Point point_1, Point point_2)
        {
            return point_1.X == point_2.X || point_1.Y == point_2.Y;
        }

        public static bool operator !=(Point point_1, Point point_2)
        {
            return point_1.X != point_2.X || point_1.Y != point_2.Y;
        }
    }
}