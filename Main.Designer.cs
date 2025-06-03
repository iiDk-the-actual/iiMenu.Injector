using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace iiMenu.Injector
{
    partial class iisStupidMenu
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
            VersionTitleText = new Label();
            Icon = new Panel();
            Title = new Label();
            LoadingImage = new Panel();
            InjectStatus = new Label();
            VersionText = new Label();
            DescriptionBox = new RichTextBox();
            Inject = new Button();
            LoadingBarBackground = new Panel();
            LoadingBarText = new Label();
            DragBar.SuspendLayout();
            LoadingBarBackground.SuspendLayout();
            SuspendLayout();
            // 
            // DragBar
            // 
            DragBar.BackColor = Color.FromArgb(255, 128, 0);
            DragBar.Controls.Add(Close);
            DragBar.Controls.Add(VersionTitleText);
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
            Close.Click += closeApplication;
            // 
            // VersionTitleText
            // 
            VersionTitleText.AutoSize = true;
            VersionTitleText.BackColor = Color.Transparent;
            VersionTitleText.Font = new Font("Agency FB", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            VersionTitleText.ForeColor = Color.NavajoWhite;
            VersionTitleText.Location = new Point(145, 1);
            VersionTitleText.Name = "VersionTitleText";
            VersionTitleText.Size = new Size(117, 25);
            VersionTitleText.TabIndex = 2;
            VersionTitleText.Text = "Version Loading...";
            VersionTitleText.MouseDown += mouseDown_Event;
            VersionTitleText.MouseMove += mouseMove_event;
            VersionTitleText.MouseUp += mouseUp_event;
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
            Icon.MouseDown += mouseDown_Event;
            Icon.MouseMove += mouseMove_event;
            Icon.MouseUp += mouseUp_event;
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
            Title.MouseDown += mouseDown_Event;
            Title.MouseMove += mouseMove_event;
            Title.MouseUp += mouseUp_event;
            // 
            // LoadingImage
            // 
            LoadingImage.BackColor = Color.Transparent;
            LoadingImage.BackgroundImage = Properties.Resources.load;
            LoadingImage.BackgroundImageLayout = ImageLayout.Stretch;
            LoadingImage.Location = new Point(133, 122);
            LoadingImage.Name = "LoadingImage";
            LoadingImage.Size = new Size(184, 184);
            LoadingImage.TabIndex = 1;
            // 
            // InjectStatus
            // 
            InjectStatus.BackColor = Color.Transparent;
            InjectStatus.Font = new Font("Agency FB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InjectStatus.ForeColor = Color.White;
            InjectStatus.Location = new Point(77, 96);
            InjectStatus.Name = "InjectStatus";
            InjectStatus.Size = new Size(300, 25);
            InjectStatus.TabIndex = 8;
            InjectStatus.Text = "Downloading SharpMonoInjector";
            InjectStatus.TextAlign = ContentAlignment.TopCenter;
            InjectStatus.Visible = false;
            // 
            // VersionText
            // 
            VersionText.BackColor = Color.Transparent;
            VersionText.Font = new Font("Agency FB", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VersionText.ForeColor = Color.White;
            VersionText.Location = new Point(142, 37);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(170, 59);
            VersionText.TabIndex = 4;
            VersionText.Text = "Loading...";
            VersionText.TextAlign = ContentAlignment.TopCenter;
            // 
            // DescriptionBox
            // 
            DescriptionBox.BackColor = Color.FromArgb(90, 40, 0);
            DescriptionBox.BorderStyle = BorderStyle.None;
            DescriptionBox.Font = new Font("Agency FB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DescriptionBox.ForeColor = Color.White;
            DescriptionBox.Location = new Point(12, 73);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.ReadOnly = true;
            DescriptionBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            DescriptionBox.Size = new Size(416, 225);
            DescriptionBox.TabIndex = 5;
            DescriptionBox.Text = "";
            DescriptionBox.Visible = false;
            // 
            // Inject
            // 
            Inject.BackColor = Color.FromArgb(255, 128, 0);
            Inject.FlatAppearance.BorderSize = 0;
            Inject.FlatStyle = FlatStyle.Flat;
            Inject.Font = new Font("Agency FB", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Inject.ForeColor = Color.White;
            Inject.Location = new Point(12, 304);
            Inject.Name = "Inject";
            Inject.Size = new Size(416, 29);
            Inject.TabIndex = 6;
            Inject.Text = "Inject";
            Inject.UseVisualStyleBackColor = false;
            Inject.Visible = false;
            Inject.MouseClick += onClickInject;
            Inject.MouseEnter += onHover;
            Inject.MouseLeave += onLeave;
            // 
            // LoadingBarBackground
            // 
            LoadingBarBackground.BackColor = Color.FromArgb(90, 40, 0);
            LoadingBarBackground.Controls.Add(LoadingBarText);
            LoadingBarBackground.Location = new Point(12, 304);
            LoadingBarBackground.Name = "LoadingBarBackground";
            LoadingBarBackground.Size = new Size(416, 29);
            LoadingBarBackground.TabIndex = 7;
            LoadingBarBackground.Visible = false;
            // 
            // LoadingBarText
            // 
            LoadingBarText.BackColor = Color.DarkOrange;
            LoadingBarText.Font = new Font("Agency FB", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LoadingBarText.ForeColor = Color.White;
            LoadingBarText.ImageAlign = ContentAlignment.TopLeft;
            LoadingBarText.Location = new Point(3, 3);
            LoadingBarText.Name = "LoadingBarText";
            LoadingBarText.Size = new Size(410, 23);
            LoadingBarText.TabIndex = 0;
            LoadingBarText.Text = "100% - Injected";
            LoadingBarText.TextAlign = ContentAlignment.MiddleCenter;
            LoadingBarText.Visible = false;
            // 
            // iisStupidMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(440, 340);
            Controls.Add(InjectStatus);
            Controls.Add(LoadingBarBackground);
            Controls.Add(Inject);
            Controls.Add(DescriptionBox);
            Controls.Add(VersionText);
            Controls.Add(LoadingImage);
            Controls.Add(DragBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "iisStupidMenu";
            Text = "ii's Stupid Menu";
            DragBar.ResumeLayout(false);
            DragBar.PerformLayout();
            LoadingBarBackground.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void StartRotation()
        {
            originalLoadingImage = Properties.Resources.load;
            LoadingImage.BackgroundImage = originalLoadingImage;

            rotationTimer = new System.Windows.Forms.Timer();
            rotationTimer.Interval = 50;
            rotationTimer.Tick += (s, e) =>
            {
                rotationAngle += 45f;
                if (rotationAngle >= 360f)
                    rotationAngle -= 360f;

                var rotated = RotateImage(originalLoadingImage, rotationAngle);

                var old = LoadingImage.BackgroundImage;
                LoadingImage.BackgroundImage = rotated;
                if (old != null && old != originalLoadingImage)
                    old.Dispose();
            };
            rotationTimer.Start();
        }

        private Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();

        private void IconBob()
        {
            originalIconImage = Properties.Resources.cone;
            Icon.BackgroundImage = originalIconImage;

            iconRotationTimer = new System.Windows.Forms.Timer();
            iconRotationTimer.Interval = 10;
            iconRotationTimer.Tick += (s, e) =>
            {
                float rotation = MathF.Sin((float)stopwatch.Elapsed.TotalSeconds * 3f) * 10f;
                var rotated = RotateImage(originalIconImage, rotation);

                var old = Icon.BackgroundImage;
                Icon.BackgroundImage = rotated;
                if (old != null && old != originalIconImage)
                    old.Dispose();
            };
            iconRotationTimer.Start();
        }

        public async Task GetLatest()
        {
            string repo = "iiDk-the-actual/iis.Stupid.Menu";
            string url = $"https://api.github.com/repos/{repo}/releases/latest";

            using HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.UserAgent.ParseAdd("CSharpApp");

            try
            {
                string response = await client.GetStringAsync(url);
                Newtonsoft.Json.Linq.JObject release = Newtonsoft.Json.Linq.JObject.Parse(response);

                string title = release["name"]?.ToString() ?? "(no title)";
                string description = release["body"]?.ToString() ?? "(no description)";

                VersionText.Text = $"Release {title}";
                VersionText.Font = new Font(VersionText.Font.FontFamily, 20, FontStyle.Italic);

                VersionTitleText.Text = $"Version {title}";

                LoadColoredText(DescriptionBox, ExtractDiffText(description));

                LoadingImage.Visible = false;
                DescriptionBox.Visible = true;
                Inject.Visible = true;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }

        void LoadColoredText(RichTextBox richTextBox, string input)
        {
            richTextBox.Clear();

            using (StringReader reader = new StringReader(input))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Color color = richTextBox.ForeColor;

                    if (line.StartsWith("+"))
                        color = Color.FromArgb(143, 242, 92);
                    else if (line.StartsWith("-"))
                        color = Color.FromArgb(242, 92, 92);

                    richTextBox.SelectionStart = richTextBox.TextLength;
                    richTextBox.SelectionLength = 0;
                    richTextBox.SelectionColor = color;

                    richTextBox.AppendText(line + Environment.NewLine);
                }

                richTextBox.SelectionColor = richTextBox.ForeColor;
            }
        }

        public class NoScrollBarRichTextBox : RichTextBox
        {
            const int WM_NCPAINT = 0x85;
            const int WM_PAINT = 0xF;
            const int WM_VSCROLL = 0x115;
            const int WM_HSCROLL = 0x114;

            const int GWL_STYLE = -16;
            const int WS_VSCROLL = 0x00200000;
            const int WS_HSCROLL = 0x00100000;

            [DllImport("user32.dll")]
            static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32.dll")]
            static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

            [DllImport("user32.dll")]
            static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

            const int SB_BOTH = 3;

            private void HideScrollBars()
            {
                IntPtr handle = this.Handle;
                int style = GetWindowLong(handle, GWL_STYLE);
                style &= ~WS_VSCROLL; // remove vertical scrollbar style
                style &= ~WS_HSCROLL; // remove horizontal scrollbar style
                SetWindowLong(handle, GWL_STYLE, style);
                ShowScrollBar(handle, SB_BOTH, false);
            }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                // After relevant messages, hide the scrollbars again
                if (m.Msg == WM_NCPAINT || m.Msg == WM_PAINT || m.Msg == WM_VSCROLL || m.Msg == WM_HSCROLL)
                {
                    HideScrollBars();
                }
            }
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
        private Label VersionTitleText;
        private new Button Close;
        private Panel LoadingImage;
        private Label VersionText;

        private System.Windows.Forms.Timer rotationTimer;
        private System.Windows.Forms.Timer iconRotationTimer;
        private float rotationAngle = 0f;
        private Image originalLoadingImage;
        private Image originalIconImage;

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

        string ExtractDiffText(string input)
        {
            var pattern = @"```diff\s*(.*?)```";
            var match = Regex.Match(input, pattern, RegexOptions.Singleline);
            if (match.Success)
            {
                return match.Groups[1].Value.Trim();
            }
            return null;
        }

        public bool IsGorillaTagRunning()
        {
            Process[] processes = Process.GetProcessesByName("Gorilla Tag");
            return processes.Length > 0;
        }

        private RichTextBox DescriptionBox;
        public Button Inject;
        private Panel LoadingBarBackground;
        private Label LoadingBarText;
        private Label InjectStatus;
    }
}
