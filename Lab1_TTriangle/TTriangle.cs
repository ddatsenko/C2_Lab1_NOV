using System;

namespace Lab1_TTriangle
{
    class TTriangle
    {
        protected double lengthA;
        protected double lengthB;
        protected double lengthC;
        public TTriangle()
        {
            lengthA = 0;
            lengthB = 0;
            lengthC = 0;
        }
        public TTriangle(double a, double b, double c)
        {
            if (a + b >= c && b + c >= a && a + c >= b)
            {
                lengthA = a;
                lengthB = b;
                lengthC = c;
            }
            else
            {
                Console.WriteLine("This triangle doesn't exist.");
            }
        }
        public double SideA
        {
            get
            {
                return lengthA;
            }
            set
            {
                if (value > 0 && value + lengthB >= lengthC && value + lengthC >= lengthB && lengthB + lengthC >= value)
                {
                    lengthA = value;
                }
            }
        }
        public double SideB
        {
            get
            {
                return lengthB;
            }
            set
            {
                if (value > 0 && lengthA + value >= lengthC && lengthA + lengthC >= value && value + lengthC >= lengthA)
                {
                    lengthB = value;
                }
            }
        }
        public double SideC
        {
            get
            {
                return lengthC;
            }
            set
            {
                if (value > 0 && lengthA + lengthB >= value && lengthA + value >= lengthB && lengthB + value >= lengthA)
                {
                    lengthC = value;
                }
            }
        }
        public double CalculatePerimeter()
        {
            return (lengthA + lengthB + lengthC);
        }
        public double CalculateArea()
        {
            return (Math.Pow((CalculatePerimeter() / 2) * (CalculatePerimeter() - lengthA) * (CalculatePerimeter() - lengthB) * (CalculatePerimeter() - lengthC), 1.0 / 2.0));
        }
    }
}
