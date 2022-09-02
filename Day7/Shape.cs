using System;

namespace Day7
{
    class Shape
    {
        //attributes
        int dim1;
        int dim2;

        //properties
        public int Dim1
        {
            set => dim1 = value; 
            get => dim1; 
        }

        public int Dim2
        {
            set => dim2 = value;
            get => dim2;
        }

        //constructors
        public Shape()
        {
            dim1 = 0;
            dim2 = 0;
        }

        public Shape(int _dim1, int _dim2)
        {
            Dim1 = _dim1;
            Dim2 = _dim2;
        }
        public void Print()
        {
            Console.WriteLine($"({dim1}:{dim2})");
        }
    }
}
