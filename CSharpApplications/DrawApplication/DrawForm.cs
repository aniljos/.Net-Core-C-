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
using System.Xml.Serialization;

namespace DrawApplication
{
    public partial class DrawForm : Form
    {

        private Shape shape;// = new ShapesLib.Rectangle();
        private ILogger logger = new ConsoleLogger();

        private List<Shape> shapes = new List<Shape>();


        public DrawForm()
        {
            InitializeComponent();
            // rectButton.Click += (sender, e) => MessageBox.Show("You clicked on the rect button");
            Shape.ShapeDrawn += shape_Drawn;
        }

        public void shape_Drawn(Shape shape)
        {
            string shape_name = shape.GetType().Name;
            //MessageBox.Show(string.Format("{0} drawn", shape_name));
        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            shape = new ShapesLib.Rectangle();
            //logger.Info("rectangle created");
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            shape = new Circle();
            //logger.Info("circle created");
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                shape.StartX = e.X;
                shape.StartY = e.Y;
            }
            else
            {
                // MessageBox.Show("Please select as shape");
            }

        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Graphics graphics = drawPanel.CreateGraphics();
                    shape.Draw(graphics, Pens.White);

                    shape.EndX = e.X;
                    shape.EndY = e.Y;


                    shape.Draw(graphics, Pens.Black);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Please select as shape" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Technical Error");
                }


            }
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {


                Graphics graphics = drawPanel.CreateGraphics();

                shape.EndX = e.X;
                shape.EndY = e.Y;
                shape.Draw(graphics, Pens.Black, true);

                shapes.Add(shape);

                //shape = shape.CreateShape();
                shape = Activator.CreateInstance(shape.GetType()) as Shape;
            }
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {

                string filePath = saveFileDialog1.FileName;
                using (StreamWriter stream = new StreamWriter(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(shapes.GetType());
                    serializer.Serialize(stream, shapes);
                }
                   


            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                using(StreamReader reader = new StreamReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(shapes.GetType());
                    shapes = serializer.Deserialize(reader) as List<Shape>;
                    Graphics graphics = drawPanel.CreateGraphics();
                    foreach (var shape in shapes)
                    {
                        shape.Draw(graphics, Pens.Black);
                    }
                }
                
            }
        }
    }
}
