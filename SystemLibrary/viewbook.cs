using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemLibrary
{
    public partial class viewbook : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public viewbook()
        {
            InitializeComponent();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            populate();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from Book_A";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataview.DataSource = ds.Tables[0];
            
            Con.Close();
        }


    }
}
