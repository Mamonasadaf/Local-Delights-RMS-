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
    public partial class UC_Add : UserControl
    {
        function fn = new function();
        string query;
        public UC_Add()
        {
            InitializeComponent();
        }

        private void UC_Add_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO dbo.items (name, category, price) values ('" + txtItemName.Text + "', '" + categorycombo.Text + "', " + txtprice.Text + ")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            categorycombo.SelectedIndex = -1;
            txtItemName.Clear();
            txtprice.Clear();
        }

        private void UC_Add_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
