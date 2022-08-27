using System;

namespace Day6
{
    class Rectangle : Shape
    {
        //constructors
        public Rectangle()
        {

        }
        public Rectangle(int _dim1, int _dim2) : base(_dim1, _dim2) 
        {

        }

        //print info...
        public override void print()
        {
            Console.WriteLine($"Rectangle: with dimension {GetDim1()},{GetDim2()}");
        }

        //calculate the area
        public override float GetArea()
        {
            return GetDim1() * GetDim2();
        }

    }
}
