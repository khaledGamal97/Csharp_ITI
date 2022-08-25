using System;

namespace Day4
{
    class Point2d
    {
        int x_dim;
        int y_dim;
        public Point2d()
        {
            x_dim = 0;
            y_dim = 0;
        }
        public Point2d(int _x_dim, int _y_dim)
        {
            x_dim = _x_dim;
            y_dim = _y_dim;
        }
        public void SetXDimension(int x)
        {
            x_dim = x;
        }
        public void SetYDimension(int y)
        {
            y_dim = y;
        }
        public int GetXDimension()
        {
            return x_dim;
        }
        public int GetYDimension()
        {
            return y_dim;
        }
        public void PrintPointDimensions()
        {
            Console.WriteLine($"the point is:[ {x_dim} , {y_dim} ]");
        }
    }
}
