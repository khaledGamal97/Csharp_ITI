using System;
namespace S1
{
    class program
    {
        public static int IsPrime(int num)
        {
            int i;
            for (i = 2; i < num; i++)
            {
                if (num %  i == 0)
                    return 0;
            }
            if (i == num)
                return 1;
            return 0;
        }
        static void Main()
        {


            int num = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("please enter a number to check:");
                num = int.Parse(Console.ReadLine());
                if (IsPrime(num) == 1)
                    Console.WriteLine($"{num} is prime!");
                else
                    Console.WriteLine($"{num} is not prime!");
            } 
        }
    }
}
