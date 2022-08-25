using System;

namespace s1 
{
    class program
    {
        static void Main5()
        {
            Console.WriteLine("Sum of Numbers from 1 to 100");
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;

            Console.WriteLine($"the sum is: {sum}");
        }
        static void Main4()
        {
            Console.WriteLine("Numbers from 1 to 100");
            for (int i = 1; i <=100 ; i++)
                Console.WriteLine(i);
        }
        static void Main3()
        {
            Console.WriteLine("Please enter the 1st number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the operation type (+ , - , * , / ):");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd number:");
            int num2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Not valid operation!");
                    break;

            }


        }
        static void Main2()
        {
            Console.WriteLine("Please enter your degree:");
            int degree = int.Parse(Console.ReadLine());
            if (degree < 50)
                Console.WriteLine("Fail!");
            else if (degree < 65)
                Console.WriteLine("Pass!");
            else if (degree < 75)
                Console.WriteLine("Good!");
            else if (degree < 85)
                Console.WriteLine("very good!");
            else
                Console.WriteLine("Excellent");

        }
        static void Main()
        {
            Console.WriteLine("Please enter the number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} is Even");
            else
                Console.WriteLine($"{num} is Odd");

        }
    }
}
