﻿using System;
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
            var triangle = new Triangle(3.0, 4.0);
            Console.WriteLine(triangle.GetPerimeter);
            Console.WriteLine(triangle.GetArea);
        }
    }
}