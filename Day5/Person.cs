namespace Day5
{
    class Person
    {
        //attributes
        int id;
        string name;
        int age;
        //constructors
        public Person()
        {
            name = "No Name";
        }
        public Person(string _name)
        {
            name = _name;
        }
        public Person(int _id, string _name, int _age)
        {
            id = _id;
            name = _name;
            age = _age;
        }
        //setters
        public void SetId(int _id) => id = _id;
        public void SetName(string _name) => name = _name;
        public void SetAge(int _age) => age = _age;
        //getters
        public int GetId() => id;
        public string GetName() => name;
        public int GetAge() => age;
        //print person's info...
        public virtual void Print()
        {
            Console.WriteLine($"Person:[id:{id} - name:{name} - age:{age}] ");
        }
    }
}
