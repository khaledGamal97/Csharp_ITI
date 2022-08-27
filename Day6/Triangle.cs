using System;

namespace Day6
{
    class Triangle :Shape
    {
        //constructors
        public Triangle()
        {

        }
        public Triangle(int _dim1, int _dim2) : base(_dim1, _dim2)
        {

        }

        //print info...
        public override void print()
        {
            Console.WriteLine($"Triangle: with dimension {GetDim1()},{GetDim2()}");
        }

        //calculate the area
        public  override float GetArea()
        {
            return 0.5f * GetDim1() * GetDim2();
        }

    }
}
