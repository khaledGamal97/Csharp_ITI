namespace Day5
{
    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Print();

            Employee e1 = new Employee("Khaled Gamal");
            Employee e2 = new Employee(1000, "Ahmed Ali", 25, 5000);
            Console.ForegroundColor= ConsoleColor.Red;
            e1.Print();
            e2.Print();

            Student s1 = new Student();
            Console.ResetColor();
            s1.Print();

            Console.ForegroundColor = ConsoleColor.Green;
            Student s2 = new Student(123,"Mohamed",16,90);
            s2.Print();

            Console.ResetColor();
            p = e2;
            p.Print();

            Console.ForegroundColor = ConsoleColor.Green;
            p = s2;  
            p.Print();

            Console.ResetColor();


        }
    }
}

