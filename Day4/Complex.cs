using System;

namespace Day4
{
    class Complex
    {
        int real;
        int imag;
        public Complex()
        {
            real = 0;
            imag = 0;
        }
        public Complex(int _real, int _imag)
        {
            real = _real;
            imag = _imag;
        }
        public void SetReal(int _real)
        {
            real = _real;
        }
        public void SetImag(int _imag)
        {
            imag = _imag;
        }
        public int GetReal()
        {
            return real;
        }
        public int GetImag()
        {
            return imag;
        }
        public void PrintComplex()
        {
            if (real != 0)
            {
                if (imag > 0)
                    Console.WriteLine($"{real}+{imag}J");
                else if (imag < 0)
                    Console.WriteLine($"{real}{imag}J");
                else 
                    Console.WriteLine($"{real}");

            }
            else
                Console.WriteLine($"{imag}J");
            
        }


    }
}
