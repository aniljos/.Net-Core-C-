using SampleLib;


namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;
            Console.WriteLine("Hello, World!");
            //DataTypes();
            CreateStudents();
            Console.WriteLine("App is over");
        }

        static void DataTypes()
        {
            int x = 10;
            Console.WriteLine("x: " + x);

            User user = new User();
            user.Name = "John";
            user.Age = 19;
            Console.WriteLine("User Name: {0}, Age: {1}", user.Name, user.Age);

        }

        static void CreateStudents()
        {
            Student student = new Student();

            //Console.WriteLine($" Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            student.Display();
            student.Id = 100;
            student.Name = "Alice";
            student.Age = 20;

            //Console.WriteLine($" Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            student.Display();

            Student student1 = new Student(101, "John", 19);
            //Console.WriteLine($" Id: {student1.Id}, Name: {student1.Name}, Age: {student1.Age}");
            student.Display();

        }
    }
}