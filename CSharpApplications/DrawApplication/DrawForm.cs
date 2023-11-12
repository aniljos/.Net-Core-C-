using ShapesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApplication
{
    public partial class DrawForm : Form
    {

        private Shape shape = new ShapesLib.Rectangle();
        private ILogger logger = new ConsoleLogger();

        private List<Shape> shapes = new List<Shape>();


        public DrawForm()
        {
            InitializeComponent();
            rectButton.Click += (sender, e) => MessageBox.Show("You clicked on the rect button");
            Shape.ShapeDrawn += shape_Drawn;
        }

        public void shape_Drawn(Shape shape)
        {
            string shape_name = shape.GetType().Name;
            MessageBox.Show(string.Format("{0} drawn", shape_name));
        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            shape = new ShapesLib.Rectangle();
            logger.Info("rectangle created");
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            shape = new Circle();
            logger.Info("circle created");
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            shape.StartX = e.X;
            shape.StartY = e.Y;
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Graphics graphics = drawPanel.CreateGraphics();
                shape.Draw(graphics, Pens.White);

                shape.EndX = e.X;
                shape.EndY = e.Y;


                shape.Draw(graphics, Pens.Black);

            }
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {

            Graphics graphics = drawPanel.CreateGraphics();
            
            shape.EndX = e.X;
            shape.EndY = e.Y;
            shape.Draw(graphics, Pens.Black, true);

            shapes.Add(shape);

            //shape = shape.CreateShape();
            shape = Activator.CreateInstance(shape.GetType()) as Shape;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = drawPanel.CreateGraphics();
            foreach (Shape shape in shapes)
            {
                shape.Draw(graphics, Pens.Black);
            }

            base.OnPaint(e);
        }
    }
}
