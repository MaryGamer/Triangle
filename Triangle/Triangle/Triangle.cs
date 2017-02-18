using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        Point A;
        Point B;
        Point C;

        Edge E1;
        Edge E2;
        Edge E3;

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

        //продолжить тут
        public Triangle(Point p1, Point p2, Point p3)
        {
            ab = new Edge(p1, p2);
            bc = new Edge(p2, p3);
            ac = new Edge(p1, p3);
        }

        public double GetPerimeter
        {
           get
            {
                return (ab.Length_Of_Edge + bc.Length_Of_Edge + ac.Length_Of_Edge);
            } 
        }

        public double GetArea
        {
            get
            {
                double properiter = GetPerimeter / 2;
                return (Math.Sqrt(properiter * (properiter - ab.Length_Of_Edge) * (properiter - bc.Length_Of_Edge) * (properiter - ac.Length_Of_Edge)));
            }
        }

        public bool IsRight
        {
            get
            {

            }
        }

        public bool IsIsosceles
        {
            get
            {

            }

        }
    }
}
