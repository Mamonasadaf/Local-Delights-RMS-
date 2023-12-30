using RMSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdateItems.Hide();
                btnRemoveItems.Hide();
            }
            else if (user == "ADMIN")
            {
                btnAddItems.Show();
                btnUpdateItems.Show();
                btnRemoveItems.Show();
                btnPlaceOrder.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_placeOrder1.Visible = true;
            uC_placeOrder1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }
        int num = 0;
        private void labelBanner_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBanner.Location = new Point(56, 357);
                labelBanner.ForeColor = Color.Blue;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.Location = new Point(95, 357);
                labelBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(242, 378);
                labelBanner.ForeColor = Color.DarkRed;
                num = 0;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            uC_Add1.Visible = false;
            uC_placeOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItems1.Visible = false;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_Add1.Visible = true;
            uC_Add1.BringToFront();
        }

        private void uC_Additems1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            uC_RemoveItems1.Visible = true;
            uC_RemoveItems1.BringToFront();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
