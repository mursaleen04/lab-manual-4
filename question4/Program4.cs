using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
   
class bookProgram
        {
            static void Main()
            {
            BookLibrary library = new BookLibrary();

                Console.WriteLine("Input 20 Books:");
                library.InputBooks();

                Console.WriteLine("\nDisplaying All Books:");
                library.PrintBooks();

                Console.Write("\nEnter a book title to search: ");
                string searchTitle = Console.ReadLine();
                library.SearchBook(searchTitle);
            }
        }

    }
