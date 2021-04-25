using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.DisplayList();

            Console.WriteLine();
            Console.WriteLine("Enter your choice name/title/checkout");
            string choice = Console.ReadLine();
            if (choice == "name")
            {
                Console.WriteLine("Enter the author  name to search");
                string name = Console.ReadLine();
                library.SearchByAuthor(name);
               
            }
            else if (choice == "title")
            {
                Console.WriteLine("Enter the Title  name to search");
                string title = Console.ReadLine();
                library.SearchByTitle(title);
               
            }
            else if (choice == "checkout")
            {


                Console.WriteLine("Select the book to check out?");
                string respond = Console.ReadLine();
                library.Checkout(respond);                
            }


            //StreamWriter writer = new StreamWriter("../../../testfile.txt");
            //writer.WriteLine("Hi test");
            //writer.Close();
            

        }
    }
}
