using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{


    public class Rectangle : Shape
    {

        public Rectangle()
        {
            
        }

        public Rectangle(int sx, int sy, int ex, int ey) : base(sx, sy, ex, ey) 
        {
           
        }
        public override double CalculateArea()
        {
            Console.WriteLine("Calculate Area of a Recatangle");
            return 100;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a Recatangle");
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                graphics.DrawRectangle(pen, StartX, StartY, EndX - StartX, EndY - StartY);
            }
            
        }

        public override void PrintPoints()
        {
            Console.WriteLine("Start Points of Rectangle: {0}, {1}, EndPoints: {2}, {3}", StartX, StartY, EndX, EndY);
        }
    }
   
}
