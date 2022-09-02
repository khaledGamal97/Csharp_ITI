namespace Day7
{
    class Employee <salary_type>
    {
        string name;
        salary_type salary;

        public string Name
        {
            set =>  name = value;
            get => name;
        }

        public salary_type Salary
        {
            set => salary = value;
            get => salary;
        }

        public Employee()
        {
            name = "Khaled";
            salary = default;
        }

        public Employee(string _name, salary_type _salary)
        {
            name = _name;
            salary = _salary;
        }
    }
}
