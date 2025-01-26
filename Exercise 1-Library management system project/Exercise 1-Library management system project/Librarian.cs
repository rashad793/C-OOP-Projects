using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Library_management_system_project
{
    internal class Librarian : User
    {
        public int EmployeeNum { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }
        public void AddBook(Books NewBook, Library library)
        {
            // addlogic
            library.AddBook(NewBook);
        }

        public void RemoveBook(Books NewBook, Library library)
        {
            // addlogic
            library.RemoveBook(NewBook);

        }

    }
}
