namespace Day5
{
    class Employee : Person
    {
        //attributes
        float salalry;
        //constructors
        public Employee()
        {
            salalry = 0;
        }
        public Employee(string _name) : base(_name)
        {

        }
        public Employee(int _id,string _name,int _age,int _salary)
        {
            SetId(_id);
            SetName(_name);
            SetAge(_age);
            salalry = _salary;

        }
        //setter
        public void SetSalary(float _salary) => salalry = _salary;
        //getter
        public float GetSalalry() => salalry;
        //print employee's info..
        public new void Print()
        {
            Console.WriteLine($"Employee:[id:{GetId()} - name:{GetName()} - age:{GetAge()} - salary:{salalry}]");
        }

    }
  
}
