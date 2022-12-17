using eventv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Library
{
    internal class program
    {
        static void Main(string[] args)
        {
            WriteLine("\t\t********************##########  Welcome to GEsys E-Library  ##########*******************\n\n");
            Thread.Sleep(1000);
            WriteLine("Main Menu");
            WriteLine("=========================");
            WriteLine("1.  Add Book to Library");
            WriteLine("2.  Display List Of Books");
            WriteLine("3.  Search For Book");
            WriteLine("4.  Issue a Book");
            WriteLine("5.  Edit a Book");
            WriteLine("6.  Delete a Book");
            WriteLine("0.  Exit");
            WriteLine("=========================\n");

            Library library = new();
            Write("Enter Your Choice: ");
            string input = ReadLine();
            switch (input)
            {
                case "1":
                    library.AddBook();
                    break;
                case "2":
                    library.DisplayBook();
                    break;
                case "3":
                    library.SearchBook();
                    break;
                case "4":
                    library.IssueBook();
                    break;
                case "5":
                    library.EditBook();
                    break;
                case "6":
                    library.DeleteBook();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    return;
            }
        }



    }
    public class Library
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Author { get; set; }
        List<Library> books = new List<Library>();

        public void AddBook()
        {
            Clear();


            WriteLine("Enter Book Name");
            string name = ReadLine();
            WriteLine("Enter Book Department");
            string dept = ReadLine();
            WriteLine("Enter the Author");
            string author = ReadLine();
            books.Add(new Library
            {
                Name = name,
                Dept = dept,
                Author = author,
            });

        }
        public void DisplayBook()
        {
            Clear();
            if (books == null)
            {
                books.Add(new Library() { Name = "Principles of Electronics", Dept = "Engineering", Author = "Emma Ngene" });
                books.Add(new Library() { Name = "Principles of Electronics", Dept = "Engineering", Author = "Emma Ngene" });
            }
            Console.WriteLine(books[1]);

            WriteLine("Display Menu");
            WriteLine("=========================");
            WriteLine("1.  List all Book Of Given Author");
            WriteLine("2.  List all Book Of Given Department");
            WriteLine("3.  List count of Book in the Library");
            WriteLine("=========================");
            Write("Enter your Choice: ");
            switch (ReadLine())
            {

            }

        }
        public void SearchBook()
        {
            Clear();
        }
        public void IssueBook()
        {
            Clear();
        }
        public void EditBook()
        {
            Clear();
        }
        public void DeleteBook()
        {
            Clear();
        }
    }
}
