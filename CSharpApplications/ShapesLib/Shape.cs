namespace ShapesLib
{

    //new Shape(); This creates an instance, This will not work since its abstract
    // Shape shape: This crates a reference, this will work
    public abstract class Shape
    {
        // Start Point & End Point
        public int StartX { get; set; }
        public int StartY { get; set; }

        public int EndX { get; set; }
        public int EndY { get; set; }


        //behaviors
        // CalcArea, CalcPerimeter, draw

        public abstract double CalculateArea();
        public abstract void Draw();

        public void PrintPoints()
        {
            Console.WriteLine("Start Points: {0}, {1}, EndPoints: {2}, {3}", StartX, StartY, EndX, EndY);

        }
    }
}