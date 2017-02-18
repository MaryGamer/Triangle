using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        Point point_x1;
        Point point_x2;

        public Edge(Point point_x1, Point point_x2)
        {
            this.point_x1 = point_x1;
            this.point_x2 = point_x2;
        }

        public Edge() //constructor по умолчанию
        {
            point_x1 = new Point(1, 1);
            point_x2 = new Point(1024, 768);
        }

        public double Length_Of_Edge
        {
            get
            {
                return (Math.Sqrt((point_x2.x - point_x1.x) + (point_x2.y - point_x1.y))); //?
            }
        }
    }
}
