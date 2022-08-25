namespace Day5
{
    class Student : Person
    {
        //attributes
        int grade;
        //setter
        public void SetGrade(int _grade) => grade = _grade;
        //getter
        public int GetGrade() => grade;
        //constructors
        public Student()
        {
            grade = 0;
        }
        public Student(string _name) : base(_name)
        {
            grade = 0;

        }
        public Student(int _id, string _name, int _age, int _grade)
        {
            SetId(_id);
            SetName(_name);
            SetAge(_age);
            grade = _grade;

        }
        //print student's info...
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Student:[id:{GetId()} - name:{GetName()} - age:{GetAge()} - grade:{grade}]");
        }

    }
}
