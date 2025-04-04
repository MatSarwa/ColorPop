using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BasicWindowsForm
{
    public class MainForm : Form
    {
        private Button button4;
        private Label label2;
        bool useAsm; 
        private Bitmap mainOriginalImage;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label label5;
        private TextBox Time;
        private Button LoadImage;
        private PictureBox resultImageBox;
        private Button SaveImage;
        private PictureBox sourceImageBox;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label labelLibrary;
        private Button buttonC;
        private Button buttonASM;
        private TextBox Threads;
        private Label label1;
        private Panel panel2;
        private Label labelPickColor;
        private TextBox Blue;
        private TextBox Green;
        private TextBox Tolerance;
        private Label label4;
        private TrackBar ToleranceBar;
        private TextBox Red;
        private Label label3;
        private Button buttonColor;
        private TrackBar ThreadsBar;
        private Bitmap processedImage;


        public MainForm()
        {
            // Initialize the form
            this.Text = "Basic Windows Form";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Threads = new System.Windows.Forms.TextBox();
            this.ThreadsBar = new System.Windows.Forms.TrackBar();
            this.labelLibrary = new System.Windows.Forms.Label();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonASM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPickColor = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.TextBox();
            this.Green = new System.Windows.Forms.TextBox();
            this.Tolerance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ToleranceBar = new System.Windows.Forms.TrackBar();
            this.Red = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.sourceImageBox = new System.Windows.Forms.PictureBox();
            this.SaveImage = new System.Windows.Forms.Button();
            this.resultImageBox = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(15, 342);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(752, 308);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Threads);
            this.panel1.Controls.Add(this.ThreadsBar);
            this.panel1.Controls.Add(this.labelLibrary);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.buttonASM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 297);
            this.panel1.TabIndex = 24;
            // 
            // Threads
            // 
            this.Threads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.Threads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Threads.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Threads.Location = new System.Drawing.Point(262, 211);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(60, 28);
            this.Threads.TabIndex = 17;
            this.Threads.Text = "8";
            this.Threads.TextChanged += new System.EventHandler(this.Threads_TextChanged);
            // 
            // ThreadsBar
            // 
            this.ThreadsBar.Location = new System.Drawing.Point(25, 160);
            this.ThreadsBar.Maximum = 64;
            this.ThreadsBar.Minimum = 1;
            this.ThreadsBar.Name = "ThreadsBar";
            this.ThreadsBar.Size = new System.Drawing.Size(301, 56);
            this.ThreadsBar.TabIndex = 18;
            this.ThreadsBar.Value = 8;
            this.ThreadsBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelLibrary
            // 
            this.labelLibrary.AutoSize = true;
            this.labelLibrary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLibrary.ForeColor = System.Drawing.Color.Ivory;
            this.labelLibrary.Location = new System.Drawing.Point(21, 16);
            this.labelLibrary.Name = "labelLibrary";
            this.labelLibrary.Size = new System.Drawing.Size(67, 24);
            this.labelLibrary.TabIndex = 6;
            this.labelLibrary.Text = "Library";
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.buttonC.Location = new System.Drawing.Point(25, 43);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(100, 30);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C#";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonASM
            // 
            this.buttonASM.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.buttonASM.Location = new System.Drawing.Point(25, 80);
            this.buttonASM.Name = "buttonASM";
            this.buttonASM.Size = new System.Drawing.Size(100, 30);
            this.buttonASM.TabIndex = 0;
            this.buttonASM.Text = "ASM";
            this.buttonASM.UseVisualStyleBackColor = true;
            this.buttonASM.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(24, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Number of Threads";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelPickColor);
            this.panel2.Controls.Add(this.Blue);
            this.panel2.Controls.Add(this.Green);
            this.panel2.Controls.Add(this.Tolerance);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ToleranceBar);
            this.panel2.Controls.Add(this.Red);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonColor);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 297);
            this.panel2.TabIndex = 26;
            // 
            // labelPickColor
            // 
            this.labelPickColor.AutoSize = true;
            this.labelPickColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPickColor.ForeColor = System.Drawing.Color.Ivory;
            this.labelPickColor.Location = new System.Drawing.Point(12, 16);
            this.labelPickColor.Name = "labelPickColor";
            this.labelPickColor.Size = new System.Drawing.Size(94, 24);
            this.labelPickColor.TabIndex = 7;
            this.labelPickColor.Text = "Pick Color";
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Blue.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Blue.Location = new System.Drawing.Point(228, 88);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(100, 28);
            this.Blue.TabIndex = 12;
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Green.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Green.Location = new System.Drawing.Point(122, 88);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(100, 28);
            this.Green.TabIndex = 11;
            // 
            // Tolerance
            // 
            this.Tolerance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.Tolerance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tolerance.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Tolerance.Location = new System.Drawing.Point(268, 211);
            this.Tolerance.Name = "Tolerance";
            this.Tolerance.Size = new System.Drawing.Size(60, 28);
            this.Tolerance.TabIndex = 14;
            this.Tolerance.TextChanged += new System.EventHandler(this.Tolerance_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tolerance";
            // 
            // ToleranceBar
            // 
            this.ToleranceBar.Location = new System.Drawing.Point(16, 160);
            this.ToleranceBar.Maximum = 255;
            this.ToleranceBar.Name = "ToleranceBar";
            this.ToleranceBar.Size = new System.Drawing.Size(288, 56);
            this.ToleranceBar.TabIndex = 9;
            this.ToleranceBar.TickFrequency = 5;
            this.ToleranceBar.Scroll += new System.EventHandler(this.TrackBarTolerance_Scroll);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Red.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Red.Location = new System.Drawing.Point(16, 88);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(100, 28);
            this.Red.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "RGB:";
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.buttonColor.Location = new System.Drawing.Point(228, 16);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 30);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.ButtonPickColor_Click);
            // 
            // sourceImageBox
            // 
            this.sourceImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.sourceImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sourceImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImageBox.Location = new System.Drawing.Point(25, 25);
            this.sourceImageBox.Name = "sourceImageBox";
            this.sourceImageBox.Size = new System.Drawing.Size(300, 200);
            this.sourceImageBox.TabIndex = 21;
            this.sourceImageBox.TabStop = false;
            // 
            // SaveImage
            // 
            this.SaveImage.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.SaveImage.Location = new System.Drawing.Point(433, 240);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(100, 30);
            this.SaveImage.TabIndex = 22;
            this.SaveImage.Text = "Save Image";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // resultImageBox
            // 
            this.resultImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.resultImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultImageBox.Location = new System.Drawing.Point(433, 25);
            this.resultImageBox.Name = "resultImageBox";
            this.resultImageBox.Size = new System.Drawing.Size(300, 200);
            this.resultImageBox.TabIndex = 23;
            this.resultImageBox.TabStop = false;
            // 
            // LoadImage
            // 
            this.LoadImage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadImage.Location = new System.Drawing.Point(25, 238);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(100, 30);
            this.LoadImage.TabIndex = 20;
            this.LoadImage.Text = "Load Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(188)))));
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time.Location = new System.Drawing.Point(673, 244);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(60, 22);
            this.Time.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(619, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Time";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Time);
            this.panel3.Controls.Add(this.LoadImage);
            this.panel3.Controls.Add(this.resultImageBox);
            this.panel3.Controls.Add(this.SaveImage);
            this.panel3.Controls.Add(this.sourceImageBox);
            this.panel3.Location = new System.Drawing.Point(15, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 324);
            this.panel3.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToleranceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void LoadImage_Click(object sender, EventArgs e)
        {
      
            ImageLoader.LoadImage(sourceImageBox);

          
            if (ImageLoader.OriginalImage != null)
            {

                mainOriginalImage = ImageLoader.OriginalImage;
            }
            else
            {
                MessageBox.Show("Nie udało się załadować obrazu.");
            }
        }



        private void ButtonPickColor_Click(object sender, EventArgs e)
        {
           
            var colorHandler = new ColorHandler(Red, Green, Blue);

          
            colorHandler.ShowColorDialogAndSetRGB();
        }


        private void TrackBarTolerance_Scroll(object sender, EventArgs e)
        {
            int tolerance = ToleranceBar.Value;
          
            Tolerance.Text = tolerance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
          
                Time.Text = string.Empty;

                if (mainOriginalImage == null)
                {
                    MessageBox.Show("Proszę załadować obraz do pierwszego PictureBoxu.");
                    return;
                }


                Bitmap inputImage = new Bitmap(ImageLoader.OriginalImage);

                int r = int.Parse(Red.Text);
                int g = int.Parse(Green.Text);
                int b = int.Parse(Blue.Text);

        
                int tolerance = int.Parse(Tolerance.Text);

                int threads = int.Parse(Threads.Text);

            
                if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255 || tolerance < 0)
                {
                    MessageBox.Show("Proszę wprowadzić prawidłowe wartości RGB (0-255) i tolerancję.");
                    return;
                }

                useAsm = false; 

            
                Color targetColor = Color.FromArgb(r, g, b);

               
                processedImage = ColorPop.ConvertToGrayscale(mainOriginalImage, targetColor, tolerance, threads, Time, useAsm);

           
                Bitmap resizedImage = new Bitmap(processedImage, new Size(resultImageBox.Width, resultImageBox.Height));
                resultImageBox.Image = resizedImage;
            }
            catch (FormatException)
            {
                MessageBox.Show("Proszę wprowadzić prawidłowe liczby w polach RGB i Tolerancji.");
            }
        }



        private void SaveImage_Click(object sender, EventArgs e)
        {
            if (mainOriginalImage == null)
            {
                MessageBox.Show("Proszę załadować obraz do pierwszego PictureBoxu.");
                return;
            }

            ImageSaver.SaveImage(processedImage); 
        }


            private void trackBar1_Scroll(object sender, EventArgs e)
            {
                Threads.Text = ThreadsBar.Value.ToString();
            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {
                if (int.TryParse(Threads.Text, out int newValue))
                {
                
                    if (newValue >= 1 && newValue <= Environment.ProcessorCount)
                    {
                        ThreadsBar.Value = newValue; 
                    }
                    else
                    {
                       
                        Threads.Text = ThreadsBar.Value.ToString(); 
                    }
                }
            }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Time.Text = string.Empty;

                if (mainOriginalImage == null)
                {
                    MessageBox.Show("Proszę załadować obraz do pierwszego PictureBoxu.");
                    return;
                }


                int r = int.Parse(Red.Text);
                int g = int.Parse(Green.Text);
                int b = int.Parse(Blue.Text);

                
                int tolerance = int.Parse(Tolerance.Text);

                int threads = int.Parse(Threads.Text);


            
                if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255 || tolerance < 0)
                {
                    MessageBox.Show("Proszę wprowadzić prawidłowe wartości RGB (0-255) i tolerancję.");
                    return;
                }

                useAsm = true; // Wybrano C#

                
                Color targetColor = Color.FromArgb(r, g, b);

                processedImage = ColorPop.ConvertToGrayscale(mainOriginalImage, targetColor, tolerance, threads, Time, useAsm);

             
                Bitmap resizedImage = new Bitmap(processedImage, new Size(resultImageBox.Width, resultImageBox.Height));
                resultImageBox.Image = resizedImage;
            }
            catch (FormatException)
            {
                MessageBox.Show("Proszę wprowadzić prawidłowe liczby w polach RGB i Tolerancji.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (sourceImageBox.Image == null)
                {
                    MessageBox.Show("Proszę załadować obraz do pierwszego PictureBoxu.");
                    return;
                }

            
                Bitmap inputImage = new Bitmap(sourceImageBox.Image);

              
                int r = int.Parse(Red.Text);
                int g = int.Parse(Green.Text);
                int b = int.Parse(Blue.Text);

             
                int tolerance = int.Parse(Tolerance.Text);

           
                if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255 || tolerance < 0)
                {
                    MessageBox.Show("Proszę wprowadzić prawidłowe wartości RGB (0-255) i tolerancję.");
                    return;
                }

                Color targetColor = Color.FromArgb(r, g, b);

                
                List<string> results = new List<string>();

                int threadCount = 1; 
                bool useAsm = false; 
                Bitmap processedImageNoAsm = ColorPop.ConvertToGrayscale(inputImage, targetColor, tolerance, threadCount, Time, useAsm);
                string elapsedTimeStrNoAsm = Time.Text;
                results.Add($"NoAsm - Threads: {threadCount} - Time: {elapsedTimeStrNoAsm}");


            
                Form resultsForm = new Form
                {
                    Text = "Wyniki czasowe",
                    Size = new Size(400, 300)
                };

                ListBox resultsListBox = new ListBox
                {
                    Dock = DockStyle.Fill,
                    DataSource = results
                };

                resultsForm.Controls.Add(resultsListBox);
                resultsForm.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Proszę wprowadzić prawidłowe liczby w polach RGB i Tolerancji.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void Tolerance_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Tolerance.Text, out int value))
            {
                // Sprawdź, czy wartość jest w zakresie TrackBara
                if (value >= ToleranceBar.Minimum && value <= ToleranceBar.Maximum)
                {
                    ToleranceBar.Value = value;
                }
                else if (value < ToleranceBar.Minimum)
                {
                    ToleranceBar.Value = ToleranceBar.Minimum;
                    Tolerance.Text = ToleranceBar.Minimum.ToString();
                }
                else if (value > ToleranceBar.Maximum)
                {
                    ToleranceBar.Value = ToleranceBar.Maximum;
                    Tolerance.Text = ToleranceBar.Maximum.ToString();
                }
            }
        }

        private void Threads_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Threads.Text, out int value))
            {
                // Sprawdź, czy wartość jest w zakresie TrackBara
                if (value >= ThreadsBar.Minimum && value <= ThreadsBar.Maximum)
                {
                    ThreadsBar.Value = value;
                }
                else if (value < ThreadsBar.Minimum)
                {
                    ThreadsBar.Value = ThreadsBar.Minimum;
                    Threads.Text = ThreadsBar.Minimum.ToString();
                }
                else if (value > ThreadsBar.Maximum)
                {
                    ThreadsBar.Value = ThreadsBar.Maximum;
                    Threads.Text = ThreadsBar.Maximum.ToString();
                }
            }
        }


    }



}
