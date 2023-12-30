namespace RMSystem.UserControls
{
    partial class UC_RemoveItems
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
            txtsearch = new TextBox();
            dataGridView1 = new DataGridView();
            DelLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 1;
            label1.Text = "Delete Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(260, 112);
            label2.Name = "label2";
            label2.Size = new Size(124, 29);
            label2.TabIndex = 2;
            label2.Text = "Item Name";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(260, 158);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(206, 30);
            txtsearch.TabIndex = 3;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(41, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(695, 251);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DelLabel
            // 
            DelLabel.AutoSize = true;
            DelLabel.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelLabel.Location = new Point(424, 472);
            DelLabel.Name = "DelLabel";
            DelLabel.Size = new Size(42, 19);
            DelLabel.TabIndex = 5;
            DelLabel.Text = "Label";
            DelLabel.Click += DelLabel_Click;
            // 
            // UC_RemoveItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DelLabel);
            Controls.Add(dataGridView1);
            Controls.Add(txtsearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_RemoveItems";
            Size = new Size(781, 514);
            Load += UC_RemoveItems_Load;
            Enter += UC_RemoveItems_Enter;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtsearch;
        private DataGridView dataGridView1;
        private Label DelLabel;
    }
}
