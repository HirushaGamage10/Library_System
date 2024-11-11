using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SystemLibrary;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace SystemLibrary

{

    public class Book
    {

        private int bookid;
        private string title;
        private string author;
        private string isbn;
        private bool availability;


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

        public Book(int bookid, string title, string author, string isbn, bool availability)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.availability = availability;
        }

        public Book()
        {
        }


        public void BorrowBook()
        {
            while (true)
            {

                try
                {
                    Console.Write("Enter Book Id : ");
                    int bookid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Member Id : ");
                    int borrow_MemberId = Convert.ToInt32(Console.ReadLine());

                    DateTime now = DateTime.Now;
                    string borrowedDate = now.ToString("yyyy-MM-dd HH:mm:ss");

                    DateTime returnDate = now.AddDays(14);
                    string txnType = "Borrowed";


                    string constring = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                    SqlConnection connection3 = new SqlConnection(constring);
                    connection3.Open();
                    if (MemberCheack(borrow_MemberId))
                    {
                        if (AvailabilityCheck(bookid))
                        {
                            Console.Write("Book is Available do you wish to continue y/n : ");
                            string borrowchoice = Console.ReadLine().ToLower();

                            if (borrowchoice.Equals("y"))
                            {
                                bool borrowed = false;

                                string sql3 = "UPDATE Book_A SET Availability = @borrowed WHERE [BookID] = @bookId";
                                string sql5 = "UPDATE Member_D SET [Borrowed Book] = [Borrowed Book] + 1 WHERE [Member Id] = @borrow_MemberId";
                                string sql4 = "INSERT INTO Transaction_T ([Book Id], [Member Id], [Borrowed Date], [Return Date], [Transaction Type]) VALUES(@bookid, @borrow_MemberId, @borrowedDate, @returnDate, @txnType)";

                                using (SqlCommand cmd = new SqlCommand(sql3, connection3))
                                {
                                    cmd.Parameters.AddWithValue("@bookId", bookid);
                                    cmd.Parameters.AddWithValue("@borrowed", borrowed);

                                    cmd.ExecuteNonQuery();
                                }
                                using (SqlCommand cmd = new SqlCommand(sql5, connection3))
                                {

                                    cmd.Parameters.AddWithValue("@borrow_MemberId", borrow_MemberId);

                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("Book Borrowed and updated successfully");
                                }
                                using (SqlCommand cmd = new SqlCommand(sql4, connection3))
                                {
                                    cmd.Parameters.AddWithValue("@bookId", bookid);
                                    cmd.Parameters.AddWithValue("@borrow_MemberId", borrow_MemberId);
                                    cmd.Parameters.AddWithValue("@borrowedDate", borrowedDate);
                                    cmd.Parameters.AddWithValue("@returnDate", returnDate);
                                    cmd.Parameters.AddWithValue("@txnType", txnType);

                                    cmd.ExecuteNonQuery();
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book is Unavailable");
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Member not Found");
                        break;
                    }
                    connection3.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }







        public bool MemberCheack(int borrow_MemberId)
        {
            bool memberAvailability = false;
            string constring = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection3 = new SqlConnection(constring);
            connection3.Open();

            string sql3 = "SELECT [Member Id] FROM Member_D WHERE [Member Id] = @borrow_MemberId";
            string sql4 = "SELECT [Borrowed Book] FROM Member_D WHERE [Member Id] = @borrow_MemberId";


            using (SqlCommand cmd = new SqlCommand(sql3, connection3))
            {

                cmd.Parameters.AddWithValue("@borrow_MemberId", borrow_MemberId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int member = reader.GetInt32(0);
                    if (member > 0)
                    {
                        memberAvailability = true;
                    }
                }
                reader.Close();
            }
            using (SqlCommand cmd = new SqlCommand(sql4, connection3))
            {

                cmd.Parameters.AddWithValue("@borrow_MemberId", borrow_MemberId);

                SqlDataReader reader2 = cmd.ExecuteReader();

                if (reader2.Read())
                {
                    int borrowBooknum = reader2.GetInt32(0);
                    if (borrowBooknum >= 6)
                    {
                        memberAvailability = false;
                    }
                }

                reader2.Close();

            }
            connection3.Close();
            return memberAvailability;
        }



        public bool AvailabilityCheck(int bookid)
        {


            string constring = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection3 = new SqlConnection(constring);
            connection3.Open();

            string sql3 = "SELECT Availability FROM Book_A WHERE [BookID] = @bookId";

            using (SqlCommand cmd = new SqlCommand(sql3, connection3))
            {

                cmd.Parameters.AddWithValue("@bookId", bookid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    availability = reader.GetBoolean(0);
                }

                reader.Close();
                connection3.Close();
            }
            return availability;
        }






        public void ReturnBook()
        {
            while (true)
            {

                try
                {
                    Console.Write("Enter Book Id : ");
                    int bookid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Member Id : ");
                    int borrow_MemberId = Convert.ToInt32(Console.ReadLine());

                    DateTime now = DateTime.Now;
                    string returnedDate = now.ToString("yyyy-MM-dd HH:mm:ss");

                    Console.Write("Do you wish to Return Book y/n : ");
                    string borrowchoice = Console.ReadLine().ToLower();

                    string txnType = "Returned";

                    if (borrowchoice.Equals("y"))
                    {
                        bool returned = true;

                        string constring = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                        SqlConnection connection3 = new SqlConnection(constring);
                        connection3.Open();

                        string sql3 = "UPDATE Book_A SET Availability = @returned WHERE [BookID] = @bookid";
                        string sql5 = "UPDATE Member_D SET [Borrowed Book] = [Borrowed Book] -1 WHERE [Member Id] = @borrow_MemberId";
                        string sql4 = "INSERT INTO Transaction_T ([Book Id], [Member Id], [Borrowed Date], [Return Date], [Transaction Type]) VALUES(@bookId, @borrow_MemberId, @borrowedDate, @returnDate, @txnType)";

                        using (SqlCommand cmd = new SqlCommand(sql3, connection3))
                        {
                            cmd.Parameters.AddWithValue("@BookID", bookid);
                            cmd.Parameters.AddWithValue("@returned", returned);

                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Book Returned and updated successfully");
                        }
                        using (SqlCommand cmd = new SqlCommand(sql5, connection3))
                        {

                            cmd.Parameters.AddWithValue("@borrow_MemberId", borrow_MemberId);
                            cmd.ExecuteNonQuery();

                        }
                        using (SqlCommand cmd = new SqlCommand(sql4, connection3))
                        {
                            cmd.Parameters.AddWithValue("@bookId", bookid);
                            cmd.Parameters.AddWithValue("@borrow_MemberId", borrow_MemberId);
                            cmd.Parameters.AddWithValue("@borrowedDate", returnedDate);
                            cmd.Parameters.AddWithValue("@returnDate", returnedDate);
                            cmd.Parameters.AddWithValue("@txnType", txnType);

                            cmd.ExecuteNonQuery();
                        }
                        connection3.Close();
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Book is Unavailable");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
 
    }   
} 
        


        
    

