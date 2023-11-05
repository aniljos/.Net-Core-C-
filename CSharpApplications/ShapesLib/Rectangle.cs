using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            Console.WriteLine("Calculate Area of a Recatangle");
            return 100;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a Recatangle");
        }
    }
   
}
