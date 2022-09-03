using System.Collections.Generic;
namespace Day8
{
    class Program
    {
        static void Main1()
        {

            //create list of strings
            List <string> list = new List<string>();

            //add items in the list
            list.Add("khaled");
            list.Add("ahmed");
            list.Add("ali");
            list.Add("sara");

            //print list's items
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========================");

            //find list's items which length > 3 
            foreach(string item in list.FindAll((item) => item.Length > 3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========================");

            //find list's items which starts with 'a'
            foreach (string item in list.FindAll((item) => item.StartsWith('a')))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========================");

            //find list's items which ends with 'a'
            foreach (string item in list.FindAll((item) => item.EndsWith('a')))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========================");



        }
        static void Main()
        {
            //create list of students
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "khaled", Age = 25 });
            students.Add(new Student() { Id = 2, Name = "ahmed", Age = 24 });
            students.Add(new Student() { Id = 3, Name = "john", Age = 18 });

            //print list of students
            foreach(Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("===========================");

            //print students have age between 20 and 30
            foreach(Student student in students.FindAll((student) => student.Age > 20 && student.Age < 30))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("===========================");

            //print students have name length > 5
            foreach (Student student in students.FindAll((student) => student.Name.Length > 5))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("===========================");

            //print students have name contains 'a'
            foreach (Student student in students.FindAll((student) => student.Name.Contains('a')))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("===========================");
        }
    }
}