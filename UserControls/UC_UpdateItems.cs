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
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {

            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            listdataGridView.DataSource = ds.Tables[0];
        }

        private void txtUpdate_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtUpdate.Text + "%'";
            DataSet ds = fn.getData(query);
            listdataGridView.DataSource = ds.Tables[0];
        }
        int id;
        private void listdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(listdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = listdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = listdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(listdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtPrice.Text = price.ToString();
            txtItemName.Text = name;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set name = '" + txtItemName.Text + "', category='"+txtCategory.Text+"', price="+txtPrice.Text+" where iid = "+id+"";
            fn.getData(query);
            MessageBox.Show("Data processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();

            txtPrice.Clear();
            txtCategory.Clear();
            txtItemName.Clear();
        }
    }
}
