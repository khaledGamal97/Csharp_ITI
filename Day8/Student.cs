namespace Day8
{
    class Student
    {
        int id;
        string name;
        int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return $"id:{id} - name:{name} - age:{age}";
        }
    }
}
