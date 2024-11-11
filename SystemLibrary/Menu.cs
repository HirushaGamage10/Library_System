using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemLibrary
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            bookAdd1.Visible = false;
            viewbook1.Visible = false;
            remove1.Visible = false;
            transactionform1.Visible = false;
            dashboard1.Visible = true;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            viewbook1.Visible = false;
            remove1.Visible = false;
            transactionform1.Visible = false;
            bookAdd1.Visible = true;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want to logout?", "Confimation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Loginform lform = new Loginform();
                lform.Show();
                this.Hide();
            }
        }

        private void member_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            bookAdd1.Visible = false;
            remove1.Visible = false;
            transactionform1.Visible = false;
            viewbook1.Visible = true;
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            bookAdd1.Visible = false;
            viewbook1.Visible = false;
            transactionform1.Visible = false;
            remove1.Visible = true;
        }

        private void transaction_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            bookAdd1.Visible = false;
            viewbook1.Visible = false;
            remove1.Visible = false;
            transactionform1.Visible = true;
        }
    }
}
