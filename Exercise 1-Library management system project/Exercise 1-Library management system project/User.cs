using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Exercise_1_Library_management_system_project
{
    internal abstract class User
    {
        public string Name { get; set; }

        public void DisplayBook(Library library)
        {
            // add logic
            library.DisplayBook();
        }
    }
}
