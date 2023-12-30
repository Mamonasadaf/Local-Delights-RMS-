namespace RMSystem
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            btnlogin = new Button();
            btnGuest = new LinkLabel();
            deletebtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(389, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(339, 259);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.Black;
            txtusername.Location = new Point(339, 302);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(240, 28);
            txtusername.TabIndex = 3;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.Black;
            txtpassword.Location = new Point(339, 379);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(240, 27);
            txtpassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(339, 343);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.AliceBlue;
            btnlogin.Location = new Point(389, 427);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(153, 32);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.AutoSize = true;
            btnGuest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuest.LinkColor = Color.Green;
            btnGuest.Location = new Point(389, 480);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(136, 21);
            btnGuest.TabIndex = 8;
            btnGuest.TabStop = true;
            btnGuest.Text = "Continue as Guest";
            btnGuest.LinkClicked += btnGuest_LinkClicked;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.FromArgb(44, 41, 51);
            deletebtn.FlatAppearance.BorderSize = 0;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.ForeColor = Color.White;
            deletebtn.Location = new Point(12, 12);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(33, 42);
            deletebtn.TabIndex = 9;
            deletebtn.Text = "X";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 41, 51);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(932, -74);
            button1.Name = "button1";
            button1.Size = new Size(75, 149);
            button1.TabIndex = 10;
            button1.Text = "_";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 41, 51);
            ClientSize = new Size(1004, 538);
            Controls.Add(button1);
            Controls.Add(deletebtn);
            Controls.Add(btnGuest);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label3;
        private Button btnlogin;
        private LinkLabel btnGuest;
        private Button deletebtn;
        private Button button1;
    }
}
