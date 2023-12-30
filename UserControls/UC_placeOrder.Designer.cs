namespace RMSystem.UserControls
{
    partial class UC_placeOrder
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
            combocategory = new ComboBox();
            txtsearch = new TextBox();
            label3 = new Label();
            itemslist = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtitemName = new TextBox();
            txtQuantityUpDown = new NumericUpDown();
            txtitemPrice = new TextBox();
            txtTotal = new TextBox();
            btnAddtocart = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnRemove = new Button();
            btnPrint = new Button();
            labelTotalAmount = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtQuantityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(49, 40);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 0;
            label1.Text = "Place Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 113);
            label2.Name = "label2";
            label2.Size = new Size(90, 26);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // combocategory
            // 
            combocategory.FlatStyle = FlatStyle.System;
            combocategory.FormattingEnabled = true;
            combocategory.Items.AddRange(new object[] { "Desserts", "Drinks", "Pakistani Food", "Fast Food" });
            combocategory.Location = new Point(33, 142);
            combocategory.Name = "combocategory";
            combocategory.Size = new Size(143, 23);
            combocategory.TabIndex = 2;
            combocategory.SelectedIndexChanged += combocategory_SelectedIndexChanged;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(33, 186);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(143, 23);
            txtsearch.TabIndex = 3;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 168);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Search";
            // 
            // itemslist
            // 
            itemslist.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemslist.FormattingEnabled = true;
            itemslist.ItemHeight = 23;
            itemslist.Location = new Point(33, 232);
            itemslist.Name = "itemslist";
            itemslist.Size = new Size(143, 257);
            itemslist.TabIndex = 6;
            itemslist.SelectedIndexChanged += itemslist_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(247, 19);
            label4.Name = "label4";
            label4.Size = new Size(111, 26);
            label4.TabIndex = 7;
            label4.Text = "Item Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(505, 21);
            label5.Name = "label5";
            label5.Size = new Size(55, 26);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(247, 96);
            label6.Name = "label6";
            label6.Size = new Size(89, 26);
            label6.TabIndex = 9;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(505, 96);
            label7.Name = "label7";
            label7.Size = new Size(58, 26);
            label7.TabIndex = 10;
            label7.Text = "Total";
            // 
            // txtitemName
            // 
            txtitemName.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtitemName.Location = new Point(247, 51);
            txtitemName.Name = "txtitemName";
            txtitemName.Size = new Size(194, 28);
            txtitemName.TabIndex = 11;
            // 
            // txtQuantityUpDown
            // 
            txtQuantityUpDown.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantityUpDown.Location = new Point(247, 137);
            txtQuantityUpDown.Name = "txtQuantityUpDown";
            txtQuantityUpDown.Size = new Size(194, 28);
            txtQuantityUpDown.TabIndex = 15;
            txtQuantityUpDown.ValueChanged += txtQuantityUpDown_ValueChanged;
            // 
            // txtitemPrice
            // 
            txtitemPrice.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtitemPrice.Location = new Point(505, 50);
            txtitemPrice.Name = "txtitemPrice";
            txtitemPrice.Size = new Size(196, 28);
            txtitemPrice.TabIndex = 16;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(505, 136);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(196, 28);
            txtTotal.TabIndex = 17;
            // 
            // btnAddtocart
            // 
            btnAddtocart.BackColor = Color.CornflowerBlue;
            btnAddtocart.FlatAppearance.BorderSize = 0;
            btnAddtocart.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnAddtocart.FlatStyle = FlatStyle.Flat;
            btnAddtocart.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddtocart.Location = new Point(544, 175);
            btnAddtocart.Name = "btnAddtocart";
            btnAddtocart.Size = new Size(157, 38);
            btnAddtocart.TabIndex = 18;
            btnAddtocart.Text = "Add To Cart";
            btnAddtocart.UseVisualStyleBackColor = false;
            btnAddtocart.Click += btnAddtocart_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(222, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(384, 173);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Item Name";
            Column1.Name = "Column1";
            Column1.Width = 91;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Unit Price";
            Column2.Name = "Column2";
            Column2.Width = 83;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            Column3.Width = 78;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "Total Price";
            Column4.Name = "Column4";
            Column4.Width = 86;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.CornflowerBlue;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(200, 434);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(136, 38);
            btnRemove.TabIndex = 20;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.CornflowerBlue;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(565, 434);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(136, 38);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.BackColor = Color.FromArgb(255, 192, 192);
            labelTotalAmount.FlatStyle = FlatStyle.Flat;
            labelTotalAmount.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalAmount.Location = new Point(368, 434);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(116, 54);
            labelTotalAmount.TabIndex = 22;
            labelTotalAmount.Text = "Rs.00";
            labelTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(377, 408);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 23;
            label9.Text = "Grand Total";
            label9.Click += label9_Click;
            // 
            // UC_placeOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label9);
            Controls.Add(labelTotalAmount);
            Controls.Add(btnPrint);
            Controls.Add(btnRemove);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddtocart);
            Controls.Add(txtTotal);
            Controls.Add(txtitemPrice);
            Controls.Add(txtQuantityUpDown);
            Controls.Add(txtitemName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(itemslist);
            Controls.Add(label3);
            Controls.Add(txtsearch);
            Controls.Add(combocategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_placeOrder";
            Size = new Size(781, 514);
            Load += UC_placeOrder_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox combocategory;
        private TextBox txtsearch;
        private Label label3;
        private ListBox itemslist;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtitemName;
        private NumericUpDown txtQuantityUpDown;
        private TextBox txtitemPrice;
        private TextBox txtTotal;
        private Button btnAddtocart;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnRemove;
        private Button btnPrint;
        private Label labelTotalAmount;
        private Label label9;
    }
}
