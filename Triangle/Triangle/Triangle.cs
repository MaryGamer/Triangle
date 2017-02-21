using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public readonly Point A;
        public readonly Point B;
        public readonly Point C;

        public readonly Edge E1;
        public readonly Edge E2;
        public readonly Edge E3;

        public Triangle()
        {
            Random rnd = new Random();
            A = new Point(rnd.Next(1, 10) * 100, rnd.Next(1, 7) * 100);
            B = new Point(rnd.Next(1, 10) * 100, rnd.Next(1, 7) * 100);
            C = new Point(rnd.Next(1, 10) * 100, rnd.Next(1, 7) * 100);
            E1 = new Edge(A, B);
            E2 = new Edge(A, C);
            E3 = new Edge(B, C);

        }


        //public Triangle(Point val_A, Point val_B, Point val_C)
        //{
        //    Edge e1 = new Edge(val_A, val_B);
        //    Edge e2 = new Edge(val_B, val_C);
        //    Edge e3 = new Edge(val_A, val_C);

        //    if (e1.Length_Of_Edge + e2.Length_Of_Edge > e3.Length_Of_Edge ||
        //       e2.Length_Of_Edge + e3.Length_Of_Edge > e1.Length_Of_Edge ||
        //       e1.Length_Of_Edge + e3.Length_Of_Edge > e2.Length_Of_Edge)
        //    {
        //        A = val_A;
        //        B = val_B;
        //        C = val_C;
        //        E1 = e1;
        //        E2 = e2;
        //        E3 = e3;
        //    }
        //}

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);

            Edge e1 = new Edge(p1, p2);
            Edge e2 = new Edge(p2, p3);
            Edge e3 = new Edge(p1, p3);

            if (e1.Length_Of_Edge + e2.Length_Of_Edge > e3.Length_Of_Edge ||
               e2.Length_Of_Edge + e3.Length_Of_Edge > e1.Length_Of_Edge ||
               e1.Length_Of_Edge + e3.Length_Of_Edge > e2.Length_Of_Edge)
            {
                A = p1;
                B = p2;
                C = p3;
                E1 = e1;
                E2 = e2;
                E3 = e3;
            }
        }

        public void Print()
        {
            Console.Write(string.Format("Triangle: ({0}-{1})-({2}-{3})-({4}-{5})",
                A.x, A.y, B.x, B.y, C.x, C.y));
            Console.Write(string.Format(", Area = {0}", this.GetArea));
            Console.Write(string.Format(", Perimeter = {0}", this.GetPerimeter));
            if (this.IsIsosceles) Console.Write(" - Isosceles");
            if (this.IsRight) Console.Write(" - Right");
            Console.WriteLine();
        }

        public double GetPerimeter
        {
            get { return E1.Length_Of_Edge + E2.Length_Of_Edge + E3.Length_Of_Edge; }
        }

        public double GetArea
        {
            get
            {
                double properiter = this.GetPerimeter / 2;
                return Math.Sqrt(properiter * (properiter - E1.Length_Of_Edge) *
                    (properiter - E2.Length_Of_Edge) * (properiter - E3.Length_Of_Edge));
            }
        }

        public bool IsRight
        {
            get
            {
                return
                    (Math.Pow(E1.Length_Of_Edge, 2) + Math.Pow(E2.Length_Of_Edge, 2) ==
                    Math.Pow(E3.Length_Of_Edge, 2)) ||
                    (Math.Pow(E1.Length_Of_Edge, 2) + Math.Pow(E3.Length_Of_Edge, 2) ==
                    Math.Pow(E2.Length_Of_Edge, 2)) ||
                    (Math.Pow(E2.Length_Of_Edge, 2) + Math.Pow(E3.Length_Of_Edge, 2) ==
                    Math.Pow(E1.Length_Of_Edge, 2));
            }
        }

        public bool IsIsosceles
        {
            get
            {
                return (E1.Length_Of_Edge == E2.Length_Of_Edge) ||
                       (E1.Length_Of_Edge == E3.Length_Of_Edge) ||
                       (E2.Length_Of_Edge == E3.Length_Of_Edge);
            }

        }
    }
}
