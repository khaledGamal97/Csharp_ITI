namespace Day9
{
    class Program
    {
        static void Main()
        {
            Complex c1 = new Complex(2,3);
            c1.Print();
            Complex c2 = new Complex();
            Complex c3 = new Complex(4,5);
            Console.WriteLine(Complex.NO);
            Complex c4 = new Complex(5,6);
            Console.WriteLine(Complex.NO);

        }
    }
}