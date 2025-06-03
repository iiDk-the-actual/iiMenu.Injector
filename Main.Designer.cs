using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace iiMenu.Injector
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            DragBar = new Panel();
            Close = new Button();
            label1 = new Label();
            Icon = new Panel();
            Title = new Label();
            panel1 = new Panel();
            Loadingtext = new Label();
            DragBar.SuspendLayout();
            SuspendLayout();
            // 
            // DragBar
            // 
            DragBar.BackColor = Color.FromArgb(255, 128, 0);
            DragBar.Controls.Add(Close);
            DragBar.Controls.Add(label1);
            DragBar.Controls.Add(Icon);
            DragBar.Controls.Add(Title);
            DragBar.ImeMode = ImeMode.Off;
            DragBar.Location = new Point(0, 0);
            DragBar.Name = "DragBar";
            DragBar.Size = new Size(440, 30);
            DragBar.TabIndex = 0;
            DragBar.MouseDown += mouseDown_Event;
            DragBar.MouseMove += mouseMove_event;
            DragBar.MouseUp += mouseUp_event;
            // 
            // Close
            // 
            Close.BackColor = Color.FromArgb(128, 64, 0);
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close.ForeColor = Color.Transparent;
            Close.Location = new Point(412, 2);
            Close.Name = "Close";
            Close.Size = new Size(26, 26);
            Close.TabIndex = 3;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agency FB", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(145, 1);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 2;
            label1.Text = "Version Loading...";
            // 
            // Icon
            // 
            Icon.BackColor = Color.Transparent;
            Icon.BackgroundImage = Properties.Resources.cone;
            Icon.BackgroundImageLayout = ImageLayout.Stretch;
            Icon.Location = new Point(2, 2);
            Icon.Name = "Icon";
            Icon.Size = new Size(26, 26);
            Icon.TabIndex = 1;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Agency FB", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(27, 0);
            Title.Name = "Title";
            Title.Size = new Size(122, 26);
            Title.TabIndex = 0;
            Title.Text = "ii's Stupid Menu";
            Title.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.load;
            originalLoadingImage = Properties.Resources.load;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(125, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 200);
            panel1.TabIndex = 1;
            // 
            // Loadingtext
            // 
            Loadingtext.AutoSize = true;
            Loadingtext.BackColor = Color.Transparent;
            Loadingtext.Font = new Font("Agency FB", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Loadingtext.ForeColor = Color.White;
            Loadingtext.Location = new Point(142, 37);
            Loadingtext.Name = "Loadingtext";
            Loadingtext.Size = new Size(170, 59);
            Loadingtext.TabIndex = 4;
            Loadingtext.Text = "Loading...";
            Loadingtext.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(440, 340);
            Controls.Add(Loadingtext);
            Controls.Add(panel1);
            Controls.Add(DragBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            DragBar.ResumeLayout(false);
            DragBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void StartRotation()
        {
            originalLoadingImage = Properties.Resources.load;
            panel1.BackgroundImage = originalLoadingImage;

            rotationTimer = new System.Windows.Forms.Timer();
            rotationTimer.Interval = 50;
            rotationTimer.Tick += (s, e) =>
            {
                rotationAngle += 45f;
                if (rotationAngle >= 360f)
                    rotationAngle -= 360f;

                var rotated = RotateImage(originalLoadingImage, rotationAngle);

                var old = panel1.BackgroundImage;
                panel1.BackgroundImage = rotated;
                if (old != null && old != originalLoadingImage)
                    old.Dispose();
            };
            rotationTimer.Start();
        }

        #endregion

        private Panel DragBar;
        private Point dragOffset;
        private bool mouseDown;

        private void mouseDown_Event(object sender, MouseEventArgs args)
        {
            dragOffset = args.Location;
            mouseDown = true;
        }

        private void mouseMove_event(object sender, MouseEventArgs args)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(args.Location);
                Location = new Point(currentScreenPos.X - dragOffset.X, currentScreenPos.Y - dragOffset.Y);
            }
        }

        private void mouseUp_event(object sender, MouseEventArgs args) =>
            mouseDown = false;

        private Label Title;
        public new Panel Icon;
        private Label label1;
        private new Button Close;
        private Panel panel1;
        private Label Loadingtext;

        private System.Windows.Forms.Timer rotationTimer;
        private float rotationAngle = 0f;
        private Image originalLoadingImage;

        private Image RotateImage(Image img, float angle)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform(img.Width / 2f, img.Height / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-img.Width / 2f, -img.Height / 2f);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, new Point(0, 0));
            }

            return bmp;
        }
    }
}
