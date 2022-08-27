using System;

namespace Test
{
    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }
        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }
}
