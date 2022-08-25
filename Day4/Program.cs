namespace Day4
{
    class Program
    {
        //task1: factorial function
        static void Main1()
        {
            Console.WriteLine("please enter the number ot get its factorial:");
            int num = int.Parse (Console.ReadLine());
            Console.WriteLine($"the factorial of {num} is {GetFactorial(num)}");
        }
        static int GetFactorial(int num)
        {
            if (num == 0)
                return 1;
            else if (num == 1)
                return 1;
          
            return num * GetFactorial(num - 1);
        }
        //task2: student degrees
        static void Main2(string[] args)
        {
            Console.WriteLine("please enter the number of students:");
            int NumStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the number of courses:");
            int NumCourses = int.Parse(Console.ReadLine());
            int [,] degree = new int[NumStudent, NumCourses];
            //enter the data of degree
            for (int i = 0; i < degree.GetLength(0); i++)
            {
                Console.WriteLine($"please enter the degree of {NumCourses} courses for student {i+1}");
                for (int j = 0; j < degree.GetLength(1); j++)
                {
                    degree[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[] SumStdDegrees = new int[NumStudent];
            //get sum of student degree courses
            for (int i = 0; i < degree.GetLength(0); i++)
            {
                for (int j = 0; j < degree.GetLength(1); j++)
                {
                    SumStdDegrees[i] += degree[i, j];
                }
            }
            int[] AvgCrsDegrees = new int[NumCourses];
            //get Average of course's degrees
            for (int j = 0; j < degree.GetLength(1); j++)
            {
                for (int i = 0; i < degree.GetLength(0); i++)
                {
                    AvgCrsDegrees[j] += degree[i, j];
                }
            }

            //print the data of degree
            for (int i = 0; i < degree.GetLength(0); i++)
            {
                for (int j = 0; j < degree.GetLength(1); j++)
                {
                    Console.Write($"{degree[i,j]} ");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{SumStdDegrees[i]}");
                Console.WriteLine();
                Console.ResetColor();

            }
            //print Average of course's degrees
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < NumCourses; i++)
            {
                Console.Write( $"{AvgCrsDegrees[i]} " ); 
            }
            Console.WriteLine();
            Console.ResetColor();
        } 
        //task3: complex class
        static void Main3()
        {
            Console.WriteLine("please enter the real part:");
            int real = int.Parse (Console.ReadLine());
            Console.WriteLine("please enter the imaginary part:");
            int imag = int.Parse(Console.ReadLine());

            Complex num1 = new Complex();
            num1.SetReal(real);
            num1.SetImag(imag);
            num1.PrintComplex();
           
        }
        //task4: employee class
        static void Main4()
        {
            Employee emp1 = new Employee("Khaled Gamal", 25, 10000);
            Employee emp2 = new Employee("Ahamed Elsayed", 24, 8000);
            emp1.GetInfo();
            emp2.GetInfo();
        }
        //task5: bank account class
        static void Main5()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.SetName("Khaled Gamal");
            bankAccount.SetAccountType("Saving");
            bankAccount.SetAccountNo(1234585);
            bankAccount.SetAccountBalance(100000);
            bankAccount.AccountInfo();
        }
        //task6 : point2d
        static void Main6()
        {
            Point2d point2D = new Point2d();
            point2D.SetXDimension(3);
            point2D.SetYDimension(5);
            Console.WriteLine($"X axis is: {point2D.GetXDimension()}");
            Console.WriteLine($"X axis is: {point2D.GetYDimension()}");
            point2D.PrintPointDimensions();
        }
    }
}