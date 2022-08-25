using System;

namespace Day4
{
    class Employee
    {
        string name;
        int age = 24;
        float salary = 2000;
        public Employee()
        {
            name = "No Name";
        }
        public Employee(string _name)
        {
            name = _name;
        }
        public Employee(string _name, int _age, float _salary)
        {
            name = _name;
            SetAge(_age);
            SetSalary(_salary);
        }
        public void SetName(string _name)
        {   
            if (_name.Length >= 3)
                name = _name;
            else
                Console.WriteLine("Not a valid name!");
        }
        public void SetAge(int _age)
        {
            if (_age >= 24 )
                age = _age;
            else
                Console.WriteLine( "Not valid age!");
        }
        public void SetSalary(float _salary)
        {
            if (_salary >2000)
                salary = _salary;
            else
                Console.WriteLine("Not valid salary!");
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public float GetSalary()
        {
            return salary;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} , Age: {age} , Salary : {salary}");
        }
    }
}
