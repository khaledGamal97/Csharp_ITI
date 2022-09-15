using System;

namespace Day9
{
    class Complex
    {
        int real;
        int img;
        static int no;
        public static int NO
        {
            get => no;
        }


        public Complex(int _real=0, int _img=0)
        {
            real= _real;
            img= _img;
            no++;
        }
        ~Complex()
        {
            no--;
        }

        int Real
        {
            set => real = value;
            get => real;
        }
        int Img
        {
            set => img = value;
            get => img;
        }
        public void Print()
        {
            Console.WriteLine($"{real}:{img}J");
        }
    }
}
