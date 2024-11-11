using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemLibrary
{
    public class Library
    {
        private int bookid;
        private string title;
        private string author;
        private string isbn;
        private bool availability;
        public List<Book> books;




        public int BookId
        {
            get { return bookid; }
            set { bookid = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public Library(int bookid, string title, string author, string isbn)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            books = new List<Book>();
        }
        

        public Library()

        {
        }


        public void AddBook()
        {
            int bookid = this.bookid;
            string title = this.title;
            string author = this.author;
            string isbn = this.isbn;

            try
            {
                string connectionString = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Book_A (BookID,Title, Author, ISBN,Availability ) VALUES (@BookId,@Title,@Author,@ISBN, 1)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookId", bookid);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@ISBN", isbn);

                    connection.Open();
                    command.ExecuteNonQuery();


                }
                MessageBox.Show("Book added successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message);
            }
        }

        public void RemoveBook()
        {
            string title = this.title;
            string isbn = this.isbn;

            try
            {

                string connectionString = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Book_A WHERE Title = @Title";
                    string query2 = "DELETE FROM Book_A WHERE ISBN = @ISBN";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    command.Parameters.AddWithValue("@Title", title);
                    sqlCommand.Parameters.AddWithValue("@ISBN", isbn);
                    connection.Open();
                    command.ExecuteNonQuery();


                }
                MessageBox.Show("Book removed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing book: " + ex.Message);
            }
        }            
    }
 }

