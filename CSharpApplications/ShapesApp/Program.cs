using ShapesLib;

namespace ShapesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //CreateShapes();
            //CreateShape();
            App();
        }


        static void App()
        {
            //create a collection of shapes;
            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Select the Task");
            Console.WriteLine("1. Create a Shape");
            Console.WriteLine("2. Display all shapes");
            Console.WriteLine("Type e to Exit");
            string str_choice = Console.ReadLine();
            while (str_choice != "e")
            {


                if (int.TryParse(str_choice, out int choice))
                {
                    Console.WriteLine("Choice Entered: " + choice);
                    if (choice == 1)
                    {
                        Console.WriteLine("Select the Type of Shape");
                        Console.WriteLine("1. Rectangle");
                        Console.WriteLine("2. Circle");

                        string str_shape_choice = Console.ReadLine();
                        if (int.TryParse(str_shape_choice, out int shape_choice))
                        {
                            if (shape_choice == 1)
                            {
                                Rectangle rect = new Rectangle(50, 50, 100, 150);
                                shapes.Add(rect);
                            }
                            else if (shape_choice == 2)
                            {
                                Circle circle = new Circle(30, 30, 250, 275);
                                shapes.Add(circle);
                            }
                            else
                            {
                                Console.WriteLine("Invalid shape type");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid shape type");
                        }
                    }

                    else if (choice == 2)
                    {
                        foreach (var shape in shapes)
                        {
                            shape.PrintPoints();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }

                Console.WriteLine("Select the Task");
                Console.WriteLine("1. Create a Shape");
                Console.WriteLine("2. Display all shapes");
                Console.WriteLine("Type e to Exit");
                str_choice = Console.ReadLine();
            }
        }

        static void CreateShapes()
        {
            //Shape shape = new Shape();

            Rectangle rect = new Rectangle();
            
            rect.CalculateArea();
            rect.Draw();
            rect.PrintPoints();

            Circle circle = new Circle();
            circle.CalculateArea();
            circle.Draw();
            circle.PrintPoints();

            Rectangle rect1 = new Rectangle(100, 100, 200, 200);

            rect1.CalculateArea();
            rect1.Draw();
            rect1.PrintPoints();

            Circle circle1 = new Circle(150, 150, 250, 250);
            circle1.CalculateArea();
            circle1.Draw();
            circle1.PrintPoints();

        }

        static void CreateShape()
        {
            Shape shape = new Rectangle(250, 250, 300, 300);
            shape.Draw();
            shape.CalculateArea();
            shape.PrintPoints();

        }

    }
}