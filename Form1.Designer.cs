namespace Digital_Painting_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            color_picker = new PictureBox();
            btn_circle = new Button();
            btn_line = new Button();
            btn_rectangle = new Button();
            btn_pencil = new Button();
            btn_eraser = new Button();
            btn_brush = new Button();
            btn_color_palate = new Button();
            pic = new Button();
            pic_box = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_box).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(btn_circle);
            panel1.Controls.Add(btn_line);
            panel1.Controls.Add(btn_rectangle);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_brush);
            panel1.Controls.Add(btn_color_palate);
            panel1.Controls.Add(pic);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 503);
            panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            color_picker.Image = Properties.Resources.color1;
            color_picker.Location = new Point(3, 202);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(85, 227);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 9;
            color_picker.TabStop = false;
            
            // 
            // btn_circle
            // 
            btn_circle.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_circle.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btn_circle.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            btn_circle.FlatStyle = FlatStyle.Popup;
            btn_circle.ForeColor = SystemColors.ActiveCaptionText;
            btn_circle.Image = (Image)resources.GetObject("btn_circle.Image");
            btn_circle.ImageAlign = ContentAlignment.BottomCenter;
            btn_circle.Location = new Point(94, 224);
            btn_circle.Name = "btn_circle";
            btn_circle.Size = new Size(54, 60);
            btn_circle.TabIndex = 8;
            btn_circle.Text = "Circle";
            btn_circle.TextAlign = ContentAlignment.BottomCenter;
            btn_circle.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_circle.UseVisualStyleBackColor = true;
            btn_circle.Click += btn_circle_Click;
            // 
            // btn_line
            // 
            btn_line.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_line.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            btn_line.FlatStyle = FlatStyle.Popup;
            btn_line.ForeColor = SystemColors.ActiveCaptionText;
            btn_line.Image = (Image)resources.GetObject("btn_line.Image");
            btn_line.ImageAlign = ContentAlignment.BottomCenter;
            btn_line.Location = new Point(94, 290);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(54, 59);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_line.UseVisualStyleBackColor = true;
            // 
            // btn_rectangle
            // 
            btn_rectangle.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_rectangle.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btn_rectangle.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            btn_rectangle.FlatStyle = FlatStyle.Popup;
            btn_rectangle.ForeColor = SystemColors.ActiveCaptionText;
            btn_rectangle.Image = (Image)resources.GetObject("btn_rectangle.Image");
            btn_rectangle.ImageAlign = ContentAlignment.BottomCenter;
            btn_rectangle.Location = new Point(94, 355);
            btn_rectangle.Name = "btn_rectangle";
            btn_rectangle.Size = new Size(54, 74);
            btn_rectangle.TabIndex = 6;
            btn_rectangle.Text = "Rectangle";
            btn_rectangle.TextAlign = ContentAlignment.BottomCenter;
            btn_rectangle.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_rectangle.UseVisualStyleBackColor = true;
            // 
            // btn_pencil
            // 
            btn_pencil.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_pencil.FlatAppearance.BorderSize = 0;
            btn_pencil.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.White;
            btn_pencil.FlatStyle = FlatStyle.Popup;
            btn_pencil.ForeColor = SystemColors.ActiveCaptionText;
            btn_pencil.Image = (Image)resources.GetObject("btn_pencil.Image");
            btn_pencil.ImageAlign = ContentAlignment.TopCenter;
            btn_pencil.Location = new Point(79, 12);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(70, 89);
            btn_pencil.TabIndex = 5;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.UseWaitCursor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            btn_eraser.FlatStyle = FlatStyle.Popup;
            btn_eraser.ForeColor = SystemColors.ActiveCaptionText;
            btn_eraser.Image = Properties.Resources.Eraser_b;
            btn_eraser.ImageAlign = ContentAlignment.BottomCenter;
            btn_eraser.Location = new Point(3, 107);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(70, 80);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_brush
            // 
            btn_brush.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_brush.FlatAppearance.MouseDownBackColor = Color.Black;
            btn_brush.FlatAppearance.MouseOverBackColor = Color.White;
            btn_brush.FlatStyle = FlatStyle.Popup;
            btn_brush.ForeColor = SystemColors.ActiveCaptionText;
            btn_brush.Image = Properties.Resources.paintb1;
            btn_brush.ImageAlign = ContentAlignment.BottomCenter;
            btn_brush.Location = new Point(79, 98);
            btn_brush.Name = "btn_brush";
            btn_brush.Size = new Size(70, 89);
            btn_brush.TabIndex = 2;
            btn_brush.Text = "Brush";
            btn_brush.TextAlign = ContentAlignment.BottomCenter;
            btn_brush.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_brush.UseVisualStyleBackColor = true;
            // 
            // btn_color_palate
            // 
            btn_color_palate.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_color_palate.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btn_color_palate.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 64);
            btn_color_palate.FlatStyle = FlatStyle.Popup;
            btn_color_palate.ForeColor = SystemColors.ActiveCaptionText;
            btn_color_palate.Image = Properties.Resources.col_a;
            btn_color_palate.ImageAlign = ContentAlignment.BottomCenter;
            btn_color_palate.Location = new Point(3, 12);
            btn_color_palate.Name = "btn_color_palate";
            btn_color_palate.Size = new Size(70, 89);
            btn_color_palate.TabIndex = 1;
            btn_color_palate.Text = "Color";
            btn_color_palate.TextAlign = ContentAlignment.BottomCenter;
            btn_color_palate.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_color_palate.UseVisualStyleBackColor = true;
            btn_color_palate.Click += button1_Click;
            // 
            // pic
            // 
            pic.ForeColor = Color.Snow;
            pic.Location = new Point(94, 193);
            pic.Name = "pic";
            pic.Size = new Size(27, 25);
            pic.TabIndex = 0;
            pic.Text = "button1";
            pic.UseVisualStyleBackColor = true;
            // 
            // pic_box
            // 
            pic_box.BackColor = Color.White;
            pic_box.Dock = DockStyle.Fill;
            pic_box.Location = new Point(0, 0);
            pic_box.Name = "pic_box";
            pic_box.Size = new Size(862, 503);
            pic_box.TabIndex = 1;
            pic_box.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 503);
            Controls.Add(panel1);
            Controls.Add(pic_box);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button pic;
        private Button btn_color_palate;
        private Button btn_brush;
        private Button btn_pencil;
        private Button btn_eraser;
        private Button btn_line;
        private Button btn_rectangle;
        private Button btn_circle;
        private PictureBox color_picker;
        private PictureBox pic_box;
    }
}
