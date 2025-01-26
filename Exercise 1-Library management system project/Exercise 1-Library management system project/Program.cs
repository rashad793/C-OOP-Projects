using Exercise_1_Library_management_system_project;
using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Principal;

namespace LibrarySystem 
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my library");
            Console.WriteLine("Librarian or User ?? (L/R)");
            char account = Console.ReadLine().ToUpper()[0];

                if (account == 'L')
                {
                    // librarian logic
                    string LibrarianName = Console.ReadLine();
                    Console.WriteLine("Enter ur name,please!");
                    Librarian l1 = new Librarian(LibrarianName);
                    Console.WriteLine($"Welcome {l1.Name}");
                    Library library = new Library();
                    while (true)
                    {
                        Console.WriteLine("What u want to do AddBOOK (A) / RemoveBook (R) / DisplayBooks (D)");
                        char opration = Console.ReadLine().ToUpper()[0];
                        switch (opration)
                        {
                            case 'A':
                                Console.WriteLine("Enter book details");
                                string BookName = Console.ReadLine();
                                string BookAuthor = Console.ReadLine();
                                int BookYear = Int32.Parse(Console.ReadLine());
                                Books book = new Books()
                                {
                                    Title = BookName,
                                    Author = BookAuthor,
                                    Year = BookYear,
                                };
                                l1.AddBook(book, library);
                            break;
                            case 'R':
                                Console.WriteLine("Enter of book u want remove");
                                BookName = Console.ReadLine();
                                BookAuthor = Console.ReadLine();
                                BookYear = Int32.Parse(Console.ReadLine());
                                book = new Books()
                                {
                                    Title = BookName,
                                    Author = BookAuthor,
                                    Year = BookYear,
                                };
                                l1.RemoveBook(book, library);
                            break;
                            case 'D':
                                Console.WriteLine(" The Book list");
                                l1.DisplayBook(library);
                            break;
                            default:
                                Environment.Exit(0);
                            break;
                        }
                    }
                }
                else if (account == 'R')
                {
                    // User
                    string UserName = Console.ReadLine();
                    Console.WriteLine("Enter ur name,please!");
                    LibaryUser user = new LibaryUser(UserName);
                    Console.WriteLine($"Welcome {user.Name}");
                    Library library = new Library();
                while (true)
                {
                    Console.WriteLine("What u want to do BorrowBooks (B)/ DisplayBooks (D)");
                    char opration = Console.ReadLine().ToUpper()[0];
                    switch (opration)
                    {
                        case 'B':
                            Console.WriteLine("Enter book details");
                            string BookName = Console.ReadLine();
                            string BookAuthor = Console.ReadLine();
                            int BookYear = Int32.Parse(Console.ReadLine());
                            Books book = new Books()
                            {
                                Title = BookName,
                                Author = BookAuthor,
                                Year = BookYear,
                            };
                            user.BorrowBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine(" The Book list");
                            user.DisplayBook(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
                else
                {
                    Console.WriteLine("Try agian");
                }
        }
    } 
}
    
