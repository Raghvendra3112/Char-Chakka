namespace CharChakka
{
    partial class admin_main
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_main));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 125);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Brown;
            label9.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(882, 0);
            label9.Name = "label9";
            label9.Size = new Size(18, 24);
            label9.TabIndex = 18;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(334, 91);
            label2.Name = "label2";
            label2.Size = new Size(178, 34);
            label2.TabIndex = 11;
            label2.Text = "Admin Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(152, 0);
            label1.Name = "label1";
            label1.Size = new Size(581, 103);
            label1.TabIndex = 10;
            label1.Text = "CharChakka";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(0, 179);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(900, 325);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 18;
            guna2PictureBox1.TabStop = false;
            // 
            // bunifuTileButton1
            // 
            bunifuTileButton1.BackColor = Color.Brown;
            bunifuTileButton1.color = Color.Brown;
            bunifuTileButton1.colorActive = Color.LightCoral;
            bunifuTileButton1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton1.ForeColor = Color.Black;
            bunifuTileButton1.Image = null;
            bunifuTileButton1.ImagePosition = 18;
            bunifuTileButton1.ImageZoom = 50;
            bunifuTileButton1.LabelPosition = 36;
            bunifuTileButton1.LabelText = "CUSTOMERS";
            bunifuTileButton1.Location = new Point(278, 142);
            bunifuTileButton1.Margin = new Padding(4, 5, 4, 5);
            bunifuTileButton1.Name = "bunifuTileButton1";
            bunifuTileButton1.Size = new Size(132, 42);
            bunifuTileButton1.TabIndex = 19;
            bunifuTileButton1.Click += bunifuTileButton1_Click;
            // 
            // bunifuTileButton3
            // 
            bunifuTileButton3.BackColor = Color.Brown;
            bunifuTileButton3.color = Color.Brown;
            bunifuTileButton3.colorActive = Color.LightCoral;
            bunifuTileButton3.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton3.ForeColor = Color.Black;
            bunifuTileButton3.Image = null;
            bunifuTileButton3.ImagePosition = 18;
            bunifuTileButton3.ImageZoom = 50;
            bunifuTileButton3.LabelPosition = 36;
            bunifuTileButton3.LabelText = "DEALERS";
            bunifuTileButton3.Location = new Point(438, 142);
            bunifuTileButton3.Margin = new Padding(4, 5, 4, 5);
            bunifuTileButton3.Name = "bunifuTileButton3";
            bunifuTileButton3.Size = new Size(132, 42);
            bunifuTileButton3.TabIndex = 21;
            bunifuTileButton3.Click += bunifuTileButton3_Click;
            // 
            // bunifuTileButton6
            // 
            bunifuTileButton6.BackColor = Color.Brown;
            bunifuTileButton6.color = Color.Brown;
            bunifuTileButton6.colorActive = Color.LightCoral;
            bunifuTileButton6.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton6.ForeColor = Color.Black;
            bunifuTileButton6.Image = null;
            bunifuTileButton6.ImagePosition = 18;
            bunifuTileButton6.ImageZoom = 50;
            bunifuTileButton6.LabelPosition = 36;
            bunifuTileButton6.LabelText = "LOGOUT";
            bunifuTileButton6.Location = new Point(360, 494);
            bunifuTileButton6.Margin = new Padding(4, 5, 4, 5);
            bunifuTileButton6.Name = "bunifuTileButton6";
            bunifuTileButton6.Size = new Size(132, 42);
            bunifuTileButton6.TabIndex = 24;
            bunifuTileButton6.Click += bunifuTileButton6_Click;
            // 
            // admin_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(900, 550);
            Controls.Add(bunifuTileButton6);
            Controls.Add(bunifuTileButton3);
            Controls.Add(bunifuTileButton1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += admin_main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
    }
}