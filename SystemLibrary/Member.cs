using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SystemLibrary
{
    public class Member  
    {
        private int memberId;
        private string memberName;
        private string memberEmail;
        private int memberContactnum;


        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        public string MemberEmail
        {
            get { return memberEmail; }
            set { memberEmail = value; }
        }

        public int MemberContactnum
        {
            get { return memberContactnum; }
            set { memberContactnum = value; }
        }

        
        public Member(int memberId, string memberName, string memberEmail, int memberContactnum)
        {
            this.memberId = memberId;
            this.memberName = memberName;
            this.memberEmail = memberEmail;
            this.memberContactnum = memberContactnum;
        }

        public Member()
        { }
        

         public void AddMember()
          { 

                Console.WriteLine("            Add Library Member          ");
                Console.WriteLine("            -------------------         ");

            while (true)
            {
                try
                {
                    Console.Write("Enter Member ID : ");
                    memberId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Member Name : ");
                    memberName = Console.ReadLine();

                    Console.Write("Enter Member Email :");
                    memberEmail = Console.ReadLine();

                    Console.Write("Enter Member Contact Number : ");
                    memberContactnum = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }

                Console.Write("Add Member y/n :");
                string memberSave = Console.ReadLine();

                if (memberSave == "y")
                {
                    try
                    {
                        int borrowBooknum = 0;

                        string connectionString = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        string query = "INSERT INTO Member_D ([Member Id],[Member Name],[Member Email],[Contact Number],[Borrowed Book]) VALUES (@memberId, @memberName,@memberEmail,@memberContactnum,@borrowBooknum)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@memberId", memberId);
                            command.Parameters.AddWithValue("@memberName", memberName);
                            command.Parameters.AddWithValue("@memberEmail", memberEmail);
                            command.Parameters.AddWithValue("@memberContactnum", memberContactnum);
                            command.Parameters.AddWithValue("@borrowBooknum", borrowBooknum);

                            command.ExecuteNonQuery();

                            Console.WriteLine("Member added successfully!");

                        }
                        connection.Close();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error adding member: " + ex.Message);
                    }
                }
                else if (memberSave == "n")
                {
                    Console.WriteLine("Member Information Remove");
                    break;
                }
            } 

         }

        public void showMember()
        {
            Console.WriteLine("                                                All Members                            ");
            Console.WriteLine("                                                -----------                            ");
            Console.WriteLine("                                                                                       ");

            string connectionString = "Data Source=HIRUSHA_GAMAGE;Initial Catalog=library_apiit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Member_D";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine($"| {"Member ID",-10} | {"Member Name",-20} | {"Member Email",-30} | {"Contact Number",-15} | {"Borrowed Book",-20} |");
                    Console.WriteLine(new string('-', 105));
                    while (reader.Read())
                    {
                        Console.WriteLine($"| {reader["Member Id"],-10} | {reader["Member Name"],-20} | {reader["Member Email"],-30} | {reader["Contact Number"],-15} | {reader["Borrowed Book"],-20} |");
                    }
                }
            }
        }
    }
}
