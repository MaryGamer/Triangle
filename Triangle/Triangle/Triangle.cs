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

        public Triangle(Point A, Point B, Point C) 
        {
            Edge e1 = new Edge(A, B);
            Edge e2 = new Edge(B, C);
            Edge e3 = new Edge(A, C);

            if (e1.Length + e2.Length > e3.Length ||
               e2.Length + e3.Length > e1.Length ||
               e1.Length + e3.Length > e2.Length)
            {
                this.A = A;
                this.B = B;
                this.C = C;
                E1 = e1;
                E2 = e2;
                E3 = e3;
            }
        }

        public double GetPerimeter
        {
            get { return E1.Length + E2.Length + E3.Length; }
        }

        public double GetArea
        {
            get
            {
                double properiter = this.GetPerimeter / 2;
                return Math.Sqrt(properiter * (properiter - E1.Length) *
                    (properiter - E2.Length) * (properiter - E3.Length));
            }
        }

        public bool IsRight
        {
            get
            {
                return
                    (Math.Pow(E1.Length, 2) + Math.Pow(E2.Length, 2) ==
                    Math.Pow(E3.Length, 2)) ||
                    (Math.Pow(E1.Length, 2) + Math.Pow(E3.Length, 2) ==
                    Math.Pow(E2.Length, 2)) ||
                    (Math.Pow(E2.Length, 2) + Math.Pow(E3.Length, 2) ==
                    Math.Pow(E1.Length, 2));
            }
        }

        public bool IsIsosceles
        {
            get
            {
                return (E1.Length == E2.Length) ||
                       (E1.Length == E3.Length) ||
                       (E2.Length == E3.Length);
            }

        }

        public static bool operator ==(Triangle one, Triangle two)
        {
            var edge1_one = one.E1.Length;
            var edge2_one = one.E2.Length;
            var edge3_one = one.E3.Length;

            var edge1_two = two.E1.Length;
            var edge2_two = two.E2.Length;
            var edge3_two = two.E3.Length;

            return edge1_one == edge1_two && edge2_one == edge2_two && edge3_one == edge3_two ||
                   edge1_one == edge2_two && edge2_one == edge1_two && edge3_one == edge3_two ||
                   edge1_one == edge3_two && edge2_one == edge1_two && edge3_one == edge1_two ||
                   edge1_one == edge1_two && edge2_one == edge3_two && edge3_one == edge2_two;
        }

        public static bool operator !=(Triangle one, Triangle two)
        {
            var edge1_one = one.E1.Length;
            var edge2_one = one.E2.Length;
            var edge3_one = one.E3.Length;

            var edge1_two = two.E1.Length;
            var edge2_two = two.E2.Length;
            var edge3_two = two.E3.Length;

            return edge1_one != edge1_two || edge1_one != edge2_two || edge1_one != edge3_two ||
                   edge2_one != edge1_one || edge2_one != edge2_two || edge2_one != edge3_two ||
                   edge3_one != edge1_two || edge3_one != edge2_two || edge3_one != edge3_two;
        }

    }
}