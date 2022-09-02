using System;

namespace Day7
{
    class Program
    {
        enum DayWeek
        {
            Saturday , Sunday , Monday , Tuesday , Wednesday , Thrusday , Friday
        }

        //create a generic function
        public static void Swap<t>(ref t value1 , ref t value2)
        {
            t temp = value1;
            value1 = value2;
            value2 = temp;
        }
        static void Main(string[] args)
        {
            //create an object from Shape's Class
            Shape shape1 = new Shape() { Dim1 = 10, Dim2=20 };
            shape1.Print();
            shape1.Dim1 += 10;
            shape1.Dim2 += 10;
            shape1.Print();

            //create an object from Point's Struct
            Point point = new Point() { X = 3 , Y = 5};
            point.Print();
            point.X = 6;
            point.Y = 7;   
            point.Print();

            //using DayWeek enum
            DayWeek dayWeek = DayWeek.Saturday;
            Console.WriteLine(dayWeek);
            dayWeek = (DayWeek) 4;
            Console.WriteLine(dayWeek);

            int x = 1 , y = 2;
            Swap <int> (ref x, ref y);
            Console.WriteLine($"x={x} , y={y}");

            float a = 2.5f, b = 3.5f;
            Swap <float> (ref a, ref b);
            Console.WriteLine($"a={a} , b={b}");

            Point point1 = new Point() { X = 10 , Y = 10 };
            Point point2 = new Point() { X = 20 , Y = 20 };
            Swap <Point> (ref point1, ref point2);
            point1.Print();
            point2.Print();

            Employee<int> emp1 = new Employee<int>();
            Employee<float> emp2 = new Employee<float>("Ahmed",1500.5f);
            Console.WriteLine(emp1.Salary);
            emp1.Salary = 5000;
            Console.WriteLine(emp1.Salary);
            Console.WriteLine(emp2.Salary);

        }
    }
}