using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Circle : Shape
    {
        public override double CalculateArea()
        {
            Console.WriteLine("Calculate Area of Circle");
            return 300;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
