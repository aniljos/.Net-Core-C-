namespace SampleLib
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _age;


        //Construtors
        // new Student()
        public Student()
        {
            Console.WriteLine("Involing the no args constructor");
        }

        // new Student(100, "Alice", 20)
        public Student(int id, string name, int age)
        {
            Console.WriteLine("Invoking the constructor with args");
            this._id = id;
            this.Name = name;
            this._age = age;
        }


        // Student s = new Student();
        // s.Id = 100; // invokes the set block
        // int id = s.Id // invokes the get block
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name { get { return _name; }  set { _name = value; } }

        public int Age { 
            get { return _age;  } 
            set {

                if(value > 0)
                {
                    _age = value;
                }
                
            } 
        }


        public void Display()
        {
            Console.WriteLine($" Id: {this.Id}, Name: {this.Name}, Age: {Age}");
        }









    }
}