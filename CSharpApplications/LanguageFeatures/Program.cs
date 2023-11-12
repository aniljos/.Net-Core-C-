namespace LanguageFeatures
{
    internal class Program
    {
        delegate int MyDelegate(int a, int b);
        delegate int CompareDelegate(Object o1, Object o2);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DelegatesDemo();
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

        static void Sort(object[] array, )
        {
            // Iterate over the array
            // Compare the elements array[i] > array[i + 1] ==> This is differenet
            // Swap the elements
        }
    }
}