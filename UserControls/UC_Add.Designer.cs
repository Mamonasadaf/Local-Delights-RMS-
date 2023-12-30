namespace RMSystem.UserControls
{
    partial class UC_Add
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            categorycombo = new ComboBox();
            txtItemName = new TextBox();
            txtprice = new TextBox();
            savebtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 35);
            label1.Name = "label1";
            label1.Size = new Size(139, 35);
            label1.TabIndex = 0;
            label1.Text = "Add Items";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            label2.Location = new Point(177, 104);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 1;
            label2.Text = "Category";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            label3.Location = new Point(177, 181);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            label4.Location = new Point(177, 268);
            label4.Name = "label4";
            label4.Size = new Size(57, 27);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // categorycombo
            // 
            categorycombo.FormattingEnabled = true;
            categorycombo.Items.AddRange(new object[] { "Desserts", "Drinks", "Pakistani Food", "Fast Food" });
            categorycombo.Location = new Point(199, 143);
            categorycombo.Name = "categorycombo";
            categorycombo.Size = new Size(262, 23);
            categorycombo.TabIndex = 4;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(199, 215);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(262, 23);
            txtItemName.TabIndex = 5;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(199, 302);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(262, 23);
            txtprice.TabIndex = 6;
            // 
            // savebtn
            // 
            savebtn.BackColor = Color.CornflowerBlue;
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(291, 353);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 38);
            savebtn.TabIndex = 7;
            savebtn.Text = "Save Items";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += savebtn_Click;
            // 
            // UC_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(savebtn);
            Controls.Add(txtprice);
            Controls.Add(txtItemName);
            Controls.Add(categorycombo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Add";
            Size = new Size(781, 514);
            Load += UC_Add_Load;
            Leave += UC_Add_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox categorycombo;
        private TextBox txtItemName;
        private TextBox txtprice;
        private Button savebtn;
    }
}
