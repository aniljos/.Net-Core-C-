﻿using System.Drawing;
using System.Xml.Serialization;

namespace ShapesLib
{

    public delegate void ShapeEventHandler(Shape shape);


    //new Shape(); This creates an instance, This will not work since its abstract
    // Shape shape: This crates a reference, this will work

    [XmlInclude(typeof(Shape))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Circle))]
    public abstract class Shape
    {
        // Start Point & End Point
        public int StartX { get; set; }
        public int StartY { get; set; }

        public int EndX { get; set; }
        public int EndY { get; set; }

        public static event ShapeEventHandler ShapeDrawn;


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

        public virtual void Draw(Graphics graphics, Pen pen, bool raiseEvent=false)
        {
            if (raiseEvent)
            {
                ShapeDrawn?.Invoke(this);
            }
            
        }

        public abstract Shape CreateShape();


        public virtual void PrintPoints()
        {
            Console.WriteLine("Start Points: {0}, {1}, EndPoints: {2}, {3}", StartX, StartY, EndX, EndY);

        }
    }
}