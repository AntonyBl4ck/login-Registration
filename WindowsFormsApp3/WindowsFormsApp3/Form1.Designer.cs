using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class ITFoxSystem
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

            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginField
            // 

            this.loginField.Text = "";
            this.loginField.AcceptsReturn = true;
            this.loginField.AllowDrop = true;
            this.loginField.Location = new System.Drawing.Point(30, 197);
            this.loginField.MinimumSize = new System.Drawing.Size(100, 0);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(125, 27);
            this.loginField.TabIndex = 2;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(30, 251);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(125, 27);
            this.passField.TabIndex = 3;
            this.passField.UseSystemPasswordChar = true;
            this.passField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinFormsApp3.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(181, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 303);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WinFormsApp3.Properties.Resources.stock_photo_grey_gradient_geometric_background_mosaic;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(127, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "R";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ITFoxSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::WinFormsApp3.Properties.Resources.stock_photo_grey_gradient_geometric_background_mosaic;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ITFoxSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITFoxSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loginField_TextChanged(object sender, EventArgs e)
        {
            string loginUser1 = loginField.Text;
            ITFoxSystem form1 = new ITFoxSystem();
            form1.Tag = loginUser1;


        }
        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private Label label1;
        private TextBox loginField;
        private TextBox passField;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;

    }
}