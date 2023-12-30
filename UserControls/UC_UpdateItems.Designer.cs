namespace RMSystem.UserControls
{
    partial class UC_UpdateItems
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
            txtUpdate = new TextBox();
            listdataGridView = new DataGridView();
            txtCategory = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtItemName = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)listdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 0;
            label1.Text = "Update Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(532, 42);
            label2.Name = "label2";
            label2.Size = new Size(135, 27);
            label2.TabIndex = 1;
            label2.Text = "Update Items";
            // 
            // txtUpdate
            // 
            txtUpdate.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUpdate.ForeColor = Color.Black;
            txtUpdate.Location = new Point(532, 72);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(204, 30);
            txtUpdate.TabIndex = 2;
            txtUpdate.TextChanged += txtUpdate_TextChanged;
            // 
            // listdataGridView
            // 
            listdataGridView.BackgroundColor = Color.White;
            listdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listdataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            listdataGridView.Location = new Point(38, 138);
            listdataGridView.Name = "listdataGridView";
            listdataGridView.Size = new Size(712, 150);
            listdataGridView.TabIndex = 3;
            listdataGridView.CellClick += listdataGridView_CellClick;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.ForeColor = Color.Black;
            txtCategory.Location = new Point(72, 340);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(204, 30);
            txtCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 310);
            label3.Name = "label3";
            label3.Size = new Size(91, 27);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(437, 340);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(204, 30);
            txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(437, 310);
            label4.Name = "label4";
            label4.Size = new Size(56, 27);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.ForeColor = Color.Black;
            txtItemName.Location = new Point(72, 427);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(204, 30);
            txtItemName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 397);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 8;
            label5.Text = "Item Name";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(437, 414);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 43);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UC_UpdateItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnUpdate);
            Controls.Add(txtItemName);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtCategory);
            Controls.Add(label3);
            Controls.Add(listdataGridView);
            Controls.Add(txtUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_UpdateItems";
            Size = new Size(781, 514);
            Load += UC_UpdateItems_Load;
            ((System.ComponentModel.ISupportInitialize)listdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUpdate;
        private DataGridView listdataGridView;
        private TextBox txtCategory;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtItemName;
        private Label label5;
        private Button btnUpdate;
    }
}
