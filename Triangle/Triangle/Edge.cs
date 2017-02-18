using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        Point A;
        Point B;

        public Edge(Point val_A, Point val_B)
        {
            if(!(val_A.x == val_B.x && val_A.y == val_B.y))
            {
                A = val_A;
                B = val_B;
            }
        }

        public Edge() //constructor по умолчанию
        {
            A = new Point(1, 1);
            B = new Point(1024, 768);
        }

        public double Length_Of_Edge
        {
            get
            {
                return Math.Sqrt(Math.Pow((this.B.x - this.A.x), 2) +
                    Math.Pow((this.B.y - this.A.y), 2));
            }
        }
    }
}
