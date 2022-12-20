
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace E_Library
{
    internal class program
    {
        static List<Library> books = new List<Library>();
        static List<Department> dept = new List<Department>();
/*        static IEnumerable<Library> category = new Library[]
        {
            new Library
            {
                Name = "Mechanical"
            },
        };*/
        static void Main(string[] args)
        {
            WriteLine("\t\t********************##########  Welcome to GEsys E-Library  ##########*******************\n\n");
            //Thread.Sleep(1000);


            ShowMainMenu();
        }

        public static void ShowMainMenu()
        {
            Clear();
            //Library book = new();
            WriteLine("Main Menu");
            WriteLine("=========================");
            WriteLine("1.  Add Book to Library");
            WriteLine("2.  Display List Of Books");
            WriteLine("3.  Search For Book");
            WriteLine("4.  Issue a Book");
            WriteLine("5.  Edit a Book");
            WriteLine("6.  Delete a Book");
            WriteLine("7.  show categories of Book");
           // WriteLine("8.  ");
            WriteLine("0.  Exit");
            WriteLine("=========================\n");

            Write("Enter Your Choice: ");
            string input = ReadLine();
            switch (input)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    DisplayBook();
                    break;
                case "3":
                    SearchBook();
                    break;
                case "4":
                   IssueBook();
                    break;
                case "5":
                    EditBook();
                    break;
                case "6":
                    DeleteBook();
                    break;
                case "7":
                    ShowCategoriesOfBook();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("invalid input");
                    return;
            }
        }

        public static Library AddBook()
        {
            Clear();

            while (true)
            {
                WriteLine("\nEnter Book Name");
                string name = ReadLine();
               // WriteLine("Enter Book Department");
                //string dept = ReadLine();
                WriteLine("Enter the Author");
                string author = ReadLine();
               var bookDetails = new Library
                {
                    Name = name,
                   // Dept = dept,
                    Author = author,
                };
                books.Add(bookDetails);
                Display(books);

                WriteLine("press enter to continue adding or Enter z to go back to main menu");
                if (ReadKey().KeyChar == 'z')
                {
                    ShowMainMenu();
                }
                return bookDetails;
            }

           
        }
        public static void DisplayBook()
        {
            Clear();

            //WriteLine(books[1]);

            WriteLine("Display Menu");
            WriteLine("=========================");
            WriteLine("1.  List all Book in the Library");
            WriteLine("2.  List all Book Of Given Department");
            //WriteLine("3.  List all ");
            WriteLine("=========================");
            Write("Enter your Choice: ");
            switch (Convert.ToInt32(ReadLine()))
            {
                case 1:
                    {
                        if (books.Count == 0)
                        {
                            books.Add(new Library() { Name = "Principles of Electronics", Dept = "Engineering", Author = "Emma Ngene" });
                            books.Add(new Library() { Name = "Computer Applications", Dept = "Engineering", Author = "Emma Ngene" });
                            Display(books);
                        }
                        else
                            WriteLine("My Library\n");
                            Display(books);
                        //select the book you want
                        WriteLine("\n\nEnter 1 to add book\n\nEnter 2 to borrow book\n \nEnter 3 to edit book\n \nEnter 4 to delete book\n enter 5: to go back to the main menu");
                        switch (ReadKey().KeyChar)
                        {
                            case '1':
                                {
                                    AddBook();
                                }
                                break;
                            case '2':
                                {
                                    Display(books);
                                    WriteLine("Enter name of the book to borrow");
                                    string input = ReadLine();
                                    var query = (from bk in books where bk.Name.Contains(input) select bk).ToList();
                                     foreach (var bk in query)
                                    {
                                        WriteLine(bk.Name);
                                    }
                                    //books.Remove(bk.Name);
                                }
                                break;
                            case '3':
                                {
                                    Display(books);
                                    WriteLine("Enter name of the book to edit");
                                    string input = ReadLine();
                                    var query = (from bk in books where bk.Name.Contains(input) select bk).ToList();
                                    
                                   foreach (var bk in query)
                                    {
                                        WriteLine("Enter the new Name");
                                        bk.Name = ReadLine();
                                        WriteLine("Enter the new Author");
                                        bk.Author = ReadLine();
                                        WriteLine(bk);
                                    }
                                }
                                break;
                            case '4':
                                {
                                    Display(books);
                                    WriteLine("Enter name of the book to delete");
                                    string input = ReadLine();
                                    var query = books.RemoveAll(bk => bk.Name == input);
                                    WriteLine("deleted successfully");
                                    //var query = (from bk in books where bk.Name.Contains(input) select bk.Name.Remove(input).ToList();
                                   // bk.Name.Remove(input);
                                   // foreach (var bk in query)
                                    //{
                                       
                                        WriteLine("deleted successfully");
                                  //  }
                                    
                                }
                                break;
                            case '5':
                                {
                                    ShowMainMenu();
                                }
                                break;
                        }
                    }
                    break;
                
            }

        }
        public static void SearchBook()
        {
            Clear();
            WriteLine("Enter 1 to search by name of the book");
            WriteLine("Enter 2 to search by Author name of the Author of the book to search");
            switch (ReadKey().KeyChar)
            {
                case '1':
                    {
                        WriteLine("Enter name of the book to search");
                        string input = ReadLine();
                        var query = (from bk in books where bk.Name.Contains(input) select bk).ToList();
                        foreach(var bk in query)
                        {
                            WriteLine(bk.Name);
                        }
                        //Display(books);
                        //return query;
                    }
                    break;
                case '2':
                    {
                        WriteLine("Enter name of the Author of the book to search");
                        string input = ReadLine();
                        var query = (from bk in books where bk.Dept.Contains(input) select bk).ToList();
                        foreach (var bk in query)
                        {
                            WriteLine(bk.Dept);
                        }

                    }
                    break;
            }


        }
        public static void IssueBook()
        {
            Clear();
        }
        public static void EditBook()
        {
            Clear();
            Display(books);
            WriteLine("select book you want to edit");

        }
        public static void DeleteBook()
        {
            Clear();
            Display(books);
            WriteLine("select book you want to edit");
        }

        public static void ShowCategoriesOfBook()
        {
            Clear();
            if(dept.Count == 0)
            {
                WriteLine("no Categories of Book");
            }
            else
            {
                WriteLine("Select Category");
                Display(dept);

            }
            WriteLine("Enter :a to create a category\n enter :z to go back to main menu");
            string input = ReadLine();
            switch (input)
            {
                case "a":
                    
                        WriteLine("Enter name of the Department");
                        dept.Add(new Department
                        {
                            name = ReadLine(),
                            libraries = new List<Library>()
                        });
                    WriteLine("select department to add book");
                    ShowCategoriesOfBook();
                    break;
                case "b":
                    ShowMainMenu();
                    break;

            }
        }
        public static void ShowEachCategory(Department department)
        {
            Clear();
            if (dept.Count == 0)
            {
                WriteLine("no Book in this department");
            }
            else
            {
                WriteLine("Select book");
                Display(department.libraries);

            }
            WriteLine("Enter :a to add book to this category\n enter :z to go back to main menu");
            string input = ReadLine();
            switch (input)
            {
                case "a":
                    {
                        department.libraries.Add(AddBook());
                        
                    }
                    break;
            }
        }


        public static void Display(List<Library> books)
        {
            Clear();
            foreach (Library book in books)
            {
                WriteLine(book.Name);
            }
            WriteLine($"Total list of books: {books.Count}");
        }
        public static void Display(List<Department> dept)
        {
            Clear();
            foreach (Department group in dept)
            {
                WriteLine(group.name);
            }
            WriteLine($"Total list of books: {dept.Count}");
        }

        public static void Display(IEnumerable<Department> dept, int start = 0, int end = int.MaxValue)
        {
            Clear();
            for (int i = start; i < Math.Min(dept.Count(), end); i++)
            {
                WriteLine($"{i + 1}  {dept.ElementAt(i).name}");
            }

           
        }

    }





}
