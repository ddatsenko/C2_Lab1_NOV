using System;

namespace Lab1_TTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            TTriangle triangle = new TTriangle(7, 5, 4);

            triangle.SideC = 1;
            triangle.SideB = 2;
            Console.WriteLine("{0} {1} {2}", triangle.SideA, triangle.SideB, triangle.SideC);
            Console.ReadKey();
        }
    }
}