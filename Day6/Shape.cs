using System;

namespace Day6
{
    abstract class Shape
    {
        //attributes
        int dim1;
        int dim2;

        //setters & getters
        public void SetDim1(int _dim1)
        {
            if (_dim1 >0)
                dim1 = _dim1;
            else
                Console.WriteLine("Invalid Value for dimension 1");
        }
        public void SetDim2(int _dim2)
        {
            if (_dim2 > 0)
                dim2 = _dim2;
            else
                Console.WriteLine("Invalid Value for dimension 2");
        }
        public int GetDim1()=> dim1;
        public int GetDim2()=> dim2;

        //constructors
        public Shape()
        {
            dim1 = 1;
            dim2 = 1;
        }
        public Shape(int _dim1, int _dim2)
        {
            SetDim1(_dim1);
            SetDim2(_dim2);
        }

        //print info...
        public virtual void print()
        {
            Console.WriteLine($"Shape: with dimension {dim1},{dim2}");
        }

        //calculate the area
        public abstract float GetArea();
    }
}
