using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static public void Print(Triangle trg)
        {
            Console.Write(string.Format("Triangle: ({0}-{1})-({2}-{3})-({4}-{5})",
                trg.A.X, trg.A.Y, trg.B.X, trg.B.Y, trg.C.X, trg.C.Y));
            Console.Write(string.Format(", Area = {0}", trg.GetArea));
            Console.Write(string.Format(", Perimeter = {0}", trg.GetPerimeter));
            if (trg.IsIsosceles) Console.Write(" - Isosceles");
            if (trg.IsRight) Console.Write(" - Right");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Triangle[] mas = new Triangle[10];

            mas[0] = new Triangle(new Point(100, 100), new Point(100, 200), new Point(200, 200)); 
            mas[1] = new Triangle(new Point(100, 100), new Point(100, 300), new Point(300, 300));
            mas[2] = new Triangle(new Point(100, 100), new Point(100, 400), new Point(400, 400));
            mas[3] = new Triangle(new Point(100, 100), new Point(100, 500), new Point(500, 500));
            mas[4] = new Triangle(new Point(100, 100), new Point(100, 600), new Point(600, 600));
            mas[5] = new Triangle(new Point(100, 100), new Point(100, 700), new Point(700, 700));
            mas[6] = new Triangle(new Point(100, 100), new Point(100, 800), new Point(800, 800));
            mas[6] = new Triangle(new Point(100, 100), new Point(100, 900), new Point(900, 900));
            mas[7] = new Triangle(new Point(100, 100), new Point(100, 300), new Point(200, 300));
            mas[8] = new Triangle(new Point(100, 100), new Point(100, 250), new Point(250, 250));
            mas[9] = new Triangle(new Point(100, 100), new Point(100, 460), new Point(460, 460));

            double SumPerimeter = 0;
            int CountPerimeter = 0;

            double SumArea = 0;
            int CountArea = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                Print(mas[i]);

                if (mas[i].IsRight)
                {
                    SumPerimeter += mas[i].GetPerimeter;
                    CountPerimeter++;
                }

                if (mas[i].IsIsosceles)
                {
                    SumArea += mas[i].GetArea;
                    CountArea++;
                }
            }

            try
            {
                double AvgPerimeter = SumPerimeter / CountPerimeter;
                Console.WriteLine(string.Format("The average perimeter of right triangles = {0}", AvgPerimeter));
            }
            catch
            {
                Console.WriteLine("No right triangles");
            }

            try
            {
                double AvgArea = SumArea / CountArea;
                Console.WriteLine(string.Format("The average perimeter of isosceles triangles = {0}", AvgArea));
            }
            catch
            {
                Console.WriteLine("No isosceles triangles");
            }

            Console.ReadLine();
        }
    }
}