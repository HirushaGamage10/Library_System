using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemLibrary
{
    public partial class remove : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public remove()
        {
            InitializeComponent();
        }


        public void populate1()
        {
            Con.Open();
            string query = "select * from Book_A";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Book_data1.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void deletebook_btn_Click(object sender, EventArgs e)
        {
            Library rbook = new Library();
            rbook.Title = book_title.Text;
            rbook.ISBN = book_isbn.Text;
            rbook.RemoveBook();
            populate1();
        }

        private void remove_Load(object sender, EventArgs e)
        {
            
        }

        private void refresh_bt_Click(object sender, EventArgs e)
        {
            populate1();
        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            string titleFilter = searchtext.Text.Trim();
            using (SqlConnection con = new SqlConnection(@"Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!string.IsNullOrEmpty(titleFilter))
                {
                    cmd.CommandText = "SELECT * FROM Book_A WHERE Title LIKE @Title";
                    cmd.Parameters.AddWithValue("@Title", "%" + titleFilter + "%");
                }
                else
                { 
                    cmd.CommandText = "SELECT * FROM Book_A";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Book_data1.DataSource = dt;
            }
        }
        int bookid;
        private void Book_data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Book_data1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                bookid = int.Parse(Book_data1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            try
            {

                using (SqlConnection con = new SqlConnection(@"Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Book_A WHERE BookID = @BookId", con);
                    cmd.Parameters.AddWithValue("@BookID", bookid);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        book_id.Text = dt.Rows[0]["BookID"].ToString();
                        book_title.Text = dt.Rows[0]["Title"].ToString();
                        book_author.Text = dt.Rows[0]["Author"].ToString();
                        book_isbn.Text = dt.Rows[0]["ISBN"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
