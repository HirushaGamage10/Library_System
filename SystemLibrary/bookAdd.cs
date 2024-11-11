using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemLibrary
{
    public partial class bookAdd : UserControl 
    {
        SqlConnection Con = new SqlConnection(@"Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        

        public bookAdd()
        {
            InitializeComponent();
        }

        
        public void populate()
        {
            Con.Open();
            string query = "select * from Book_A";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Book_data.DataSource = ds.Tables[0];
            Con.Close();
        }

        public void clearform()
        {
            book_id.Text = "";
            book_title.Text = "";
            book_author.Text = ""; 
            book_isbn.Text = "";
        }



        private void addbook_btn_Click(object sender, EventArgs e)
        { 
            Library abook = new Library();
            abook.BookId = Convert.ToInt32(book_id.Text);
            abook.Title = book_title.Text;
            abook.Author = book_author.Text;
            abook.ISBN = book_isbn.Text;
            abook.AddBook();
            populate();
            
        }

        private void bookAdd_Load(object sender, EventArgs e)
        {
           
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearform();
            populate();
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

                Book_data.DataSource = dt;
            }
        }

        private void Book_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    
}
