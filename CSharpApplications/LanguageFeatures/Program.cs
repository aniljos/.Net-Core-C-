namespace LanguageFeatures
{

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    internal class Program
    {
        delegate int MyDelegate(int a, int b);
        delegate int CompareDelegate(Object o1, Object o2);

        //delegete for an Event

        delegate void EventDelegate(int value);
        static event EventDelegate myEvent;


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //DelegatesDemo();
            //EventsDemo();
            ReflectionDemo();
        }

        static void Subscriber1(int value)
        {
            Console.WriteLine("In Subscriber 1: " + value);

        }

        static void Subscriber2(int value)
        {
            Console.WriteLine("In Subscriber 2: " + value);

        }

        static void EventsDemo()
        {
            //Subscribe to event;
            myEvent += Subscriber1;
            myEvent += Subscriber2;


            //publish the event

            myEvent.Invoke(100);

            // Unsubscribe
            myEvent -= Subscriber2;

            myEvent.Invoke(200);
        }

        static void DelegatesDemo()
        {
            Console.WriteLine("Sum: " + Sum(6, 9));
            Console.WriteLine("Multiply: " + Multiply(6, 9));

            //MyDelegate myDelegate = new MyDelegate(Sum);
            MyDelegate myDelegate = Sum;
            Console.WriteLine("Sum: " + myDelegate(6, 9));

            //myDelegate = new MyDelegate(Multiply);
            myDelegate = Multiply;
            Console.WriteLine("Multiply: " + myDelegate(6, 9));

            myDelegate = (x, y) => x - y;
            Console.WriteLine("Subtraction: " + myDelegate(6, 9));

        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int CompareShapes(Object o1, Object o2)
        {
            return 0;
        }
        static int CompareProducts(Object o1, Object o2)
        {
            return 0;
        }

        // Shape [] shapes = new Shapes[10];
        // Sort(shapes, CompareShapes)

        // Product [] products = new Products[5];
        //Sort(products, CompareProducts);

        static void Sort(object[] array, CompareDelegate del)
        {
            // Iterate over the array
            // Compare the elements array[i] > array[i + 1] ==> This is differenet
            
            //int isGreater = del(o1, o2);
            
            // Swap the elements
        }


        public static void ReflectionDemo()
        {
            //Get Type Information
            int x = 46;
            
            object obj = x;
            Type type = obj.GetType();
            Console.WriteLine("name of type: {0}", type.Name);
            var members = type.GetMembers();
            foreach (var item in members)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("----------------------------------------------");
            obj = new Product();
            type = obj.GetType();
            Console.WriteLine("name of type: {0}", type.Name);
            members = type.GetMembers();
            foreach (var item in members)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}