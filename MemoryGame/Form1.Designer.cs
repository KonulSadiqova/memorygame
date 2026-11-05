namespace memorygame
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            labelXalYazi = new Label();
            labelXalSay = new Label();
            btnYeni = new Button();
            btnCix = new Button();
            pictureBoxTrue = new PictureBox();
            pictureBoxFalse = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFalse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(45, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 168);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(242, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 168);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(620, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(126, 168);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(423, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(126, 168);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(242, 247);
            panel5.Name = "panel5";
            panel5.Size = new Size(126, 168);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(45, 247);
            panel6.Name = "panel6";
            panel6.Size = new Size(126, 168);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(620, 247);
            panel7.Name = "panel7";
            panel7.Size = new Size(126, 168);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(423, 247);
            panel8.Name = "panel8";
            panel8.Size = new Size(126, 168);
            panel8.TabIndex = 2;
            // 
            // labelXalYazi
            // 
            labelXalYazi.AutoSize = true;
            labelXalYazi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelXalYazi.ForeColor = Color.White;
            labelXalYazi.Location = new Point(45, 497);
            labelXalYazi.Name = "labelXalYazi";
            labelXalYazi.Size = new Size(47, 28);
            labelXalYazi.TabIndex = 4;
            labelXalYazi.Text = "Xal:";
            // 
            // labelXalSay
            // 
            labelXalSay.AutoSize = true;
            labelXalSay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelXalSay.ForeColor = Color.White;
            labelXalSay.Location = new Point(84, 497);
            labelXalSay.Name = "labelXalSay";
            labelXalSay.Size = new Size(24, 28);
            labelXalSay.TabIndex = 5;
            labelXalSay.Text = "0";
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(413, 497);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(145, 41);
            btnYeni.TabIndex = 6;
            btnYeni.Text = "Yeni Oyun";
            btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnCix
            // 
            btnCix.Location = new Point(620, 497);
            btnCix.Name = "btnCix";
            btnCix.Size = new Size(145, 41);
            btnCix.TabIndex = 7;
            btnCix.Text = "Çıxış";
            btnCix.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTrue
            // 
            pictureBoxTrue.Image = (Image)resources.GetObject("pictureBoxTrue.Image");
            pictureBoxTrue.Location = new Point(203, 486);
            pictureBoxTrue.Name = "pictureBoxTrue";
            pictureBoxTrue.Size = new Size(62, 52);
            pictureBoxTrue.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTrue.TabIndex = 8;
            pictureBoxTrue.TabStop = false;
            pictureBoxTrue.Visible = false;
            // 
            // pictureBoxFalse
            // 
            pictureBoxFalse.Image = (Image)resources.GetObject("pictureBoxFalse.Image");
            pictureBoxFalse.Location = new Point(294, 486);
            pictureBoxFalse.Name = "pictureBoxFalse";
            pictureBoxFalse.Size = new Size(62, 52);
            pictureBoxFalse.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFalse.TabIndex = 9;
            pictureBoxFalse.TabStop = false;
            pictureBoxFalse.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(785, 567);
            Controls.Add(pictureBoxFalse);
            Controls.Add(pictureBoxTrue);
            Controls.Add(btnCix);
            Controls.Add(btnYeni);
            Controls.Add(labelXalSay);
            Controls.Add(labelXalYazi);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Memory game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFalse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label labelXalYazi;
        private Label labelXalSay;
        private Button btnYeni;
        private Button btnCix;
        private PictureBox pictureBoxTrue;
        private PictureBox pictureBoxFalse;
    }
}
