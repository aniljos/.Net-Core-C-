namespace DrawApplication
{
    public partial class Form1 : Form
    {

        private int shape;

        private int startX;
        private int startY;

        private int endX;
        private int endY;


        public Form1()
        {
            InitializeComponent();
        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You clicked the rectangle button");
            shape = 1;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            shape = 2;
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {

            endX = e.X;
            endY = e.Y;

            Graphics graphics = drawPanel.CreateGraphics();

            if(shape == 1)
            {
                graphics.DrawRectangle(Pens.Black, startX, startY, endX - startX, endY - startY);
            }else if(shape == 2)
            {
                if (endX > startX && endY > startY)
                {
                    graphics.DrawArc(Pens.Black, startX, startY, endX - startX, endY - startY, 0, 360);
                }
            }
            

            
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics graphics = drawPanel.CreateGraphics();

                if(shape == 1)
                {
                    graphics.DrawRectangle(Pens.White, startX, startY, endX - startX, endY - startY);
                }
                else if(shape == 2)
                {
                    if(endX > startX && endY > startY)
                    {
                        graphics.DrawArc(Pens.White, startX, startY, endX - startX, endY - startY, 0, 360);
                    }
                    
                }
                

                endX = e.X;
                endY = e.Y;


                if (shape == 1)
                {
                    graphics.DrawRectangle(Pens.Black, startX, startY, endX - startX, endY - startY);
                }
                else if (shape == 2)
                {
                    if (endX > startX && endY > startY)
                    {
                        graphics.DrawArc(Pens.Black, startX, startY, endX - startX, endY - startY, 0, 360);
                    }
                }
            }
        }
    }
}