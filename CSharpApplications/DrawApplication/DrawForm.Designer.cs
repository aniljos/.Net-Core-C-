namespace DrawApplication
{
    partial class DrawForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rectButton = new Button();
            circleButton = new Button();
            drawPanel = new Panel();
            SuspendLayout();
            // 
            // rectButton
            // 
            rectButton.Location = new Point(300, 23);
            rectButton.Name = "rectButton";
            rectButton.Size = new Size(112, 34);
            rectButton.TabIndex = 0;
            rectButton.Text = "Rect";
            rectButton.UseVisualStyleBackColor = true;
            rectButton.Click += rectButton_Click;
            // 
            // circleButton
            // 
            circleButton.Location = new Point(485, 23);
            circleButton.Name = "circleButton";
            circleButton.Size = new Size(112, 34);
            circleButton.TabIndex = 1;
            circleButton.Text = "Circle";
            circleButton.UseVisualStyleBackColor = true;
            circleButton.Click += circleButton_Click;
            // 
            // drawPanel
            // 
            drawPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drawPanel.BackColor = Color.White;
            drawPanel.Location = new Point(-1, 114);
            drawPanel.Name = "drawPanel";
            drawPanel.Size = new Size(977, 412);
            drawPanel.TabIndex = 2;
            drawPanel.MouseDown += drawPanel_MouseDown;
            drawPanel.MouseMove += drawPanel_MouseMove;
            drawPanel.MouseUp += drawPanel_MouseUp;
            // 
            // DrawForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 530);
            Controls.Add(drawPanel);
            Controls.Add(circleButton);
            Controls.Add(rectButton);
            Name = "DrawForm";
            Text = "DrawForm";
            ResumeLayout(false);
        }

        #endregion

        private Button rectButton;
        private Button circleButton;
        private Panel drawPanel;
    }
}