using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSystem.UserControls
{
    public partial class UC_placeOrder : UserControl
    {
        function fn = new function();
        String query;

        public UC_placeOrder()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //itemslist.Items.Clear();
            String category = combocategory.Text;
            query = "select name from items where category = '" + category + "'";
            showItemList(query);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //itemslist.Items.Clear();
            String category = combocategory.Text;
            query = "select name from items where category = '" + category + "' and name like '" + txtsearch.Text + "%'";
            showItemList(query);
        }
        private void showItemList(String query)
        {
            itemslist.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                itemslist.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void itemslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();

            String text = itemslist.GetItemText(itemslist.SelectedItem);
            txtitemName.Text = text;
            query = "select price from items where name='" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                txtitemPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtitemPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        protected int n, total = 0;
        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtitemName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtitemPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Text;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quntity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labelTotalAmount.Text = "Rs. " + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = " Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = " Total Payable Amount is : " + labelTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);


            total = 0;
            dataGridView1.Rows.Clear();
            labelTotalAmount.Text = "Rs. " + total;

        }

        private void UC_placeOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
