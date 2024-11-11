using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace SystemLibrary
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            int choice;
            
            
            do
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("┌───────────────────────────────────────────┐");
                Console.WriteLine("│               Library System              │");
                Console.WriteLine("└───────────────────────────────────────────┘");
                Console.ResetColor();
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1) Add Member");
                Console.WriteLine("2) View Member List");
                Console.WriteLine("3) Open GUI");
                Console.WriteLine("4) Borrow Book");
                Console.WriteLine("5) Return Book");
                Console.WriteLine("6) Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddMember();
                        break;
                    case 2:
                        showMember();
                        break;
                    case 3:
                        OpenWindowsFormsApp();
                        break;
                    case 4:
                        BorrowBook();
                        break;
                    case 5:
                        ReturnBook();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 6);
        }

        static void AddMember()
        {
            Member member = new Member();
            member.AddMember();
        }
        

        static void OpenWindowsFormsApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Form1());
             
            

        }

        static void BorrowBook()
        {
           Book bbook = new Book();
           bbook.BorrowBook();
        }

        static void ReturnBook()
        {
            Book rbook = new Book();
            rbook.ReturnBook();   
        }
        static void showMember()
        {
            Member smember = new Member();
            smember.showMember();
        }
    }
    
}
