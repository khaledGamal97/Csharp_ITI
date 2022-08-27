using System;

namespace Day6
{
    class Program
    {
        public static void PrintShapeArea(Shape s)
        {
            s.print();
            Console.WriteLine($"The area of shape is: {s.GetArea()}");
        }
        static void Main(string[] args)
        {
            Shape s1 = new Rectangle(10,10);
            PrintShapeArea(s1);

            Shape s2 = new Triangle(10,10);
            PrintShapeArea(s2);

            Rectangle r1 = new Rectangle(10,20);
            PrintShapeArea(r1);

            Triangle t1 = new Triangle(30,40);
            PrintShapeArea(t1);
            
        }
    }
}