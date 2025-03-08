using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    using System;

    class BookLibrary
    {
        private book[] books = new book[20];
        private int count = 0;

        public void InputBooks()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter details for book " + (i + 1) + ":");
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Major Area: ");
                string major = Console.ReadLine();
                Console.Write("Sub Area: ");
                string sub = Console.ReadLine();
                Console.Write("Number of Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                books[count] = new book(isbn, title, price, major, sub, pages);
                count++;
                Console.WriteLine();
            }
        }

        public void PrintBooks()
        {
            Console.WriteLine("\nList of Books:");
            for (int i = 0; i < count; i++)
            {
                books[i].Display();
            }
        }

        public void SearchBook(string title)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nBook Found:");
                    books[i].Display();
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }
       

class book
    {
        public string ISBN;
        public string Title;
        public double Price;
        public string MajorArea;
        public string SubArea;
        public int NumPages;

        public book(string isbn, string title, double price, string major, string sub, int pages)
        {
            ISBN = isbn;
            Title = title;
            Price = price;
            MajorArea = major;
            SubArea = sub;
            NumPages = pages;
        }

        public void Display()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Major Area: " + MajorArea);
            Console.WriteLine("Sub Area: " + SubArea);
            Console.WriteLine("Pages: " + NumPages);
            Console.WriteLine();
        }
    }

}
}
