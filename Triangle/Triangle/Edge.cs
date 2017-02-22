using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        public readonly Point A;
        public readonly Point B;

        public Edge(Point val_A, Point val_B) 
        {
            if (!(val_A.X == val_B.X && val_A.Y == val_B.Y))
            {
                A = val_A;
                B = val_B;
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((this.B.X - this.A.X), 2) +
                    Math.Pow((this.B.Y - this.A.Y), 2));
            }
        }

        public static bool operator ==(Edge first, Edge second)
        {
            return first.A == second.A && first.B == second.B ||
                   first.A == second.B && first.B == second.A;
        }

        public static bool operator !=(Edge first, Edge second)
        {
            return !(first.A == second.A && first.B == second.B ||
                   first.A == second.B && first.B == second.A);
        }
    }
}