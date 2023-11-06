using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Circle : Shape
    {

        public Circle()
        {
            
        }

        public Circle(int sx, int sy, int ex, int ey) : base(sx, sy, ex, ey)
        {

        }



        public override double CalculateArea()
        {
            Console.WriteLine("Calculate Area of Circle");
            return 300;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }

        public override void PrintPoints()
        {
            Console.WriteLine("printing circle points");
            base.PrintPoints();

            //Console.WriteLine("Start Points of Rectangle: {0}, {1}, EndPoints: {2}, {3}", StartX, StartY, EndX, EndY);
        }
    }
}
