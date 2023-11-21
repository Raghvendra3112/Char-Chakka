namespace CharChakka
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Mycar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Mycar).BeginInit();
            Myprogress.SuspendLayout();
            SuspendLayout();
            // 
            // Mycar
            // 
            Mycar.FillColor = Color.Transparent;
            Mycar.Image = (Image)resources.GetObject("Mycar.Image");
            Mycar.ImageRotate = 0F;
            Mycar.Location = new Point(43, 41);
            Mycar.Name = "Mycar";
            Mycar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Mycar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Mycar.Size = new Size(158, 163);
            Mycar.SizeMode = PictureBoxSizeMode.Zoom;
            Mycar.TabIndex = 0;
            Mycar.TabStop = false;
            Mycar.Click += guna2CirclePictureBox1_Click;
            // 
            // Myprogress
            // 
            Myprogress.BackColor = Color.LightCoral;
            Myprogress.Controls.Add(Mycar);
            Myprogress.FillColor = Color.Transparent;
            Myprogress.FillThickness = 8;
            Myprogress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Myprogress.ForeColor = Color.White;
            Myprogress.Location = new Point(267, 71);
            Myprogress.Minimum = 0;
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressColor = Color.LightGray;
            Myprogress.ProgressColor2 = Color.LightGray;
            Myprogress.ProgressThickness = 8;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogress.Size = new Size(247, 247);
            Myprogress.TabIndex = 1;
            Myprogress.Text = "guna2CircleProgressBar1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(185, 321);
            label1.Name = "label1";
            label1.Size = new Size(430, 77);
            label1.TabIndex = 2;
            label1.Text = "CharChakka";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Myprogress);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)Mycar).EndInit();
            Myprogress.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Mycar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}