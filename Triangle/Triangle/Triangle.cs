using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public readonly Edge ab;
        public readonly Edge bc;
        public readonly Edge ac;

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
