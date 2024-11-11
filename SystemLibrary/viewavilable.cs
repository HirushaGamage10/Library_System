using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemLibrary
{
    public partial class viewavilable : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public viewavilable()
        {
            InitializeComponent();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
           DisplayAvailableBooks();
        }

        public void DisplayAvailableBooks()
        {
            Con.Open();
            string query = "select * from Book_A WHERE Availability = 1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataview_1.DataSource = ds.Tables[0];
            Con.Close();
        }
        





        private void goback_btn_Click(object sender, EventArgs e)
        {
            admin adform = new admin();
            adform.Show();
            this.Hide();
        }
    }
}
