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


        public Shape() { }
        public Shape(int sx, int sy, int ex, int ey)
        {
            StartX = sx;
            StartY = sy;
            EndX = ex;
            EndY = ey;
        }
        
        //behaviors
        // CalcArea, CalcPerimeter, draw

        public abstract double CalculateArea();
        public abstract void Draw();

        public virtual void PrintPoints()
        {
            Console.WriteLine("Start Points: {0}, {1}, EndPoints: {2}, {3}", StartX, StartY, EndX, EndY);

        }
    }
}