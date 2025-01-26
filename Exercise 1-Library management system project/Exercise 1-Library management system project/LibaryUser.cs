using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Library_management_system_project
{
    internal class LibaryUser : User 
    {   
        public LibraryCard Card { get; set; }
        public LibaryUser(string name)
        {
            Name = name;
        }
       

        public void BorrowBook(Books book, Library library)
        {
            // add logic
            library.BorrowBook(book);
        }
    }
}
