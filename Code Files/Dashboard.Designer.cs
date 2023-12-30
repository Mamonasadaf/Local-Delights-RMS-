namespace RMSystem
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            minButton = new Button();
            logoutlbl = new LinkLabel();
            btnExit = new Button();
            btnRemoveItems = new Button();
            btnUpdateItems = new Button();
            btnAddItems = new Button();
            btnPlaceOrder = new Button();
            panel2 = new Panel();
            uC_RemoveItems1 = new UserControls.UC_RemoveItems();
            uC_UpdateItems1 = new UserControls.UC_UpdateItems();
            uC_placeOrder1 = new UserControls.UC_placeOrder();
            uC_Add1 = new UserControls.UC_Add();
            labelBanner = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(minButton);
            panel1.Controls.Add(logoutlbl);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRemoveItems);
            panel1.Controls.Add(btnUpdateItems);
            panel1.Controls.Add(btnAddItems);
            panel1.Controls.Add(btnPlaceOrder);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 514);
            panel1.TabIndex = 0;
            // 
            // minButton
            // 
            minButton.FlatAppearance.BorderSize = 0;
            minButton.FlatStyle = FlatStyle.Flat;
            minButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minButton.ForeColor = Color.White;
            minButton.Location = new Point(25, 3);
            minButton.Name = "minButton";
            minButton.Size = new Size(31, 52);
            minButton.TabIndex = 6;
            minButton.Text = "_";
            minButton.UseVisualStyleBackColor = true;
            minButton.Click += minButton_Click;
            // 
            // logoutlbl
            // 
            logoutlbl.AutoSize = true;
            logoutlbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutlbl.LinkColor = Color.White;
            logoutlbl.Location = new Point(59, 474);
            logoutlbl.Name = "logoutlbl";
            logoutlbl.Size = new Size(63, 23);
            logoutlbl.TabIndex = 5;
            logoutlbl.TabStop = true;
            logoutlbl.Text = "LogOut";
            logoutlbl.LinkClicked += logoutlbl_LinkClicked;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Cornsilk;
            btnExit.Location = new Point(3, 20);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemoveItems
            // 
            btnRemoveItems.BackColor = Color.CornflowerBlue;
            btnRemoveItems.FlatAppearance.BorderSize = 0;
            btnRemoveItems.FlatStyle = FlatStyle.Flat;
            btnRemoveItems.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            btnRemoveItems.ForeColor = Color.White;
            btnRemoveItems.Location = new Point(34, 332);
            btnRemoveItems.Name = "btnRemoveItems";
            btnRemoveItems.Size = new Size(163, 50);
            btnRemoveItems.TabIndex = 3;
            btnRemoveItems.Text = "Remove Items";
            btnRemoveItems.UseVisualStyleBackColor = false;
            btnRemoveItems.Click += btnRemoveItems_Click;
            // 
            // btnUpdateItems
            // 
            btnUpdateItems.BackColor = Color.CornflowerBlue;
            btnUpdateItems.FlatAppearance.BorderSize = 0;
            btnUpdateItems.FlatStyle = FlatStyle.Flat;
            btnUpdateItems.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            btnUpdateItems.ForeColor = Color.White;
            btnUpdateItems.Location = new Point(34, 263);
            btnUpdateItems.Name = "btnUpdateItems";
            btnUpdateItems.Size = new Size(163, 50);
            btnUpdateItems.TabIndex = 2;
            btnUpdateItems.Text = "Update Items";
            btnUpdateItems.UseVisualStyleBackColor = false;
            btnUpdateItems.Click += btnUpdateItems_Click;
            // 
            // btnAddItems
            // 
            btnAddItems.BackColor = Color.CornflowerBlue;
            btnAddItems.FlatAppearance.BorderSize = 0;
            btnAddItems.FlatStyle = FlatStyle.Flat;
            btnAddItems.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            btnAddItems.ForeColor = Color.White;
            btnAddItems.Location = new Point(34, 193);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Size = new Size(163, 50);
            btnAddItems.TabIndex = 1;
            btnAddItems.Text = "Add Items";
            btnAddItems.UseVisualStyleBackColor = false;
            btnAddItems.Click += btnAddItems_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.CornflowerBlue;
            btnPlaceOrder.FlatAppearance.BorderSize = 0;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(34, 120);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(163, 50);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(uC_RemoveItems1);
            panel2.Controls.Add(uC_UpdateItems1);
            panel2.Controls.Add(uC_placeOrder1);
            panel2.Controls.Add(uC_Add1);
            panel2.Controls.Add(labelBanner);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(210, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 514);
            panel2.TabIndex = 1;
            // 
            // uC_RemoveItems1
            // 
            uC_RemoveItems1.BackColor = Color.White;
            uC_RemoveItems1.Location = new Point(-2, 0);
            uC_RemoveItems1.Name = "uC_RemoveItems1";
            uC_RemoveItems1.Size = new Size(781, 514);
            uC_RemoveItems1.TabIndex = 8;
            // 
            // uC_UpdateItems1
            // 
            uC_UpdateItems1.BackColor = Color.White;
            uC_UpdateItems1.Location = new Point(-2, 0);
            uC_UpdateItems1.Name = "uC_UpdateItems1";
            uC_UpdateItems1.Size = new Size(781, 514);
            uC_UpdateItems1.TabIndex = 7;
            // 
            // uC_placeOrder1
            // 
            uC_placeOrder1.BackColor = Color.White;
            uC_placeOrder1.Location = new Point(1, 0);
            uC_placeOrder1.Name = "uC_placeOrder1";
            uC_placeOrder1.Size = new Size(781, 514);
            uC_placeOrder1.TabIndex = 6;
            // 
            // uC_Add1
            // 
            uC_Add1.BackColor = Color.White;
            uC_Add1.Location = new Point(0, 0);
            uC_Add1.Name = "uC_Add1";
            uC_Add1.Size = new Size(781, 514);
            uC_Add1.TabIndex = 5;
            // 
            // labelBanner
            // 
            labelBanner.AutoSize = true;
            labelBanner.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBanner.Location = new Point(189, 359);
            labelBanner.Name = "labelBanner";
            labelBanner.Size = new Size(349, 56);
            labelBanner.TabIndex = 4;
            labelBanner.Text = "Local Delights";
            labelBanner.Click += labelBanner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 308);
            label1.Name = "label1";
            label1.Size = new Size(57, 37);
            label1.TabIndex = 3;
            label1.Text = "To";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1004, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnPlaceOrder;
        private Button btnRemoveItems;
        private Button btnUpdateItems;
        private Button btnAddItems;
        private Button btnExit;
        private LinkLabel logoutlbl;
        private PictureBox pictureBox1;
        public Label labelBanner;
        public Label label1;
        private System.Windows.Forms.Timer timer1;
        private UserControls.UC_Add uC_Add1;
        private UserControls.UC_placeOrder uC_placeOrder1;
        private UserControls.UC_UpdateItems uC_UpdateItems1;
        private UserControls.UC_RemoveItems uC_RemoveItems1;
        private Button minButton;
        //private UserControls.UC_Additems uC_Additems1;
    }
}