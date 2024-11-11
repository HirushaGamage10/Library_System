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
    public partial class transactionform : UserControl
    {
        public transactionform()
        {
            InitializeComponent();
        }

        private void refresh_btn1_Click(object sender, EventArgs e)
        {
            transactionBook();
        }

        private void transactionBook()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            try
            {
                Con.Open();
                string query = "select * from Transaction_T";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                transaction_data.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error {ex} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
