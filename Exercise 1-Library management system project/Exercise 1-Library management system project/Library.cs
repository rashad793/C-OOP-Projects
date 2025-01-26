using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Library_management_system_project
{
    internal class Library
    {
        private Books[] books = new Books[100]; //maximum capacity
        private int CurrentBookCount = 0;

        private Books[] borrowedbooks = new Books[50];
        private int CurrentBorrowedBookCount = 0;

        public void AddBook(Books book)
        {
            // add logic
            if (CurrentBookCount < books.Length)
            {
                books[CurrentBookCount] = book;
                CurrentBookCount++;
                Console.WriteLine("Book added successflly");
            }
            else
            {
                Console.WriteLine("books capacity is full");
            }
        }

        public void RemoveBook(Books book)
        {
            // add logic
            int index = Array.IndexOf(books, book);
            if (books.Contains(book))
            {
                books[index] = null;
                CurrentBookCount--;
                Console.WriteLine("Book removed successflly");
            }
            else
            {
                Console.WriteLine("book is not found");
            }
        }
        
        public void DisplayBook()
        {
            // add logic
            for (int i = 0; i < CurrentBookCount; i++)
            {
                Console.WriteLine(books[1].Title);
            }
        }
        
        public void BorrowBook(Books book)
        {
            // add logic
            if (CurrentBorrowedBookCount < borrowedbooks.Length)
            {
                borrowedbooks[CurrentBorrowedBookCount] = book;
                CurrentBorrowedBookCount++;
                Console.WriteLine("Book borrowed successflly");
            }
            else
            {
                Console.WriteLine("borrowed books capacity is full");
            }
        }

    }
}
