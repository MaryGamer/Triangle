using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle[] mas = new Triangle[10];

            mas[0] = new Triangle(100, 100, 100, 200, 200, 200);
            mas[1] = new Triangle(100, 100, 100, 300, 300, 300);
            mas[2] = new Triangle(100, 100, 100, 400, 400, 400);
            mas[3] = new Triangle(100, 100, 100, 500, 500, 500);
            mas[4] = new Triangle(100, 100, 100, 600, 600, 600);
            mas[5] = new Triangle(100, 100, 100, 700, 700, 700);
            mas[6] = new Triangle(100, 100, 100, 800, 800, 800);
            mas[6] = new Triangle(100, 100, 100, 900, 900, 900);
            mas[7] = new Triangle(100, 100, 100, 300, 200, 300);
            mas[8] = new Triangle(100, 100, 100, 250, 250, 250);
            mas[9] = new Triangle(100, 100, 100, 460, 460, 460);

            double SumPerimeter = 0;
            int CountPerimeter = 0;

            double SumArea = 0;
            int CountArea = 0;

            for (int i = 0; i < 10; i++)
            {
                mas[i].Print();

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
