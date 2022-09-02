namespace Day7
{
    struct Point
    {
        int x;
        int y;

        public int X
        {
            set => x = value; 
            get => x;
        }

        public int Y 
        { 
            set => y = value;
            get => y;
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }

        public void Print()
        {
            System.Console.WriteLine($"Point:({X}-{Y})");
        }
    }
}
