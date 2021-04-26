using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the library");            
            Library library = new Library();

            

            Console.WriteLine("Please select a menu item");
            Console.WriteLine("1.) Display library inventory.");
            Console.WriteLine("2.) Search for a book by author");
            Console.WriteLine("3.) Search for a book by title");
            Console.WriteLine("4.) Checkout book");
            Console.WriteLine("5.) Return a book");          
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                library.DisplayList();
            }
            else if  (choice == "2")
            {
                Console.WriteLine("Enter the author name to search");
                string name1 = Console.ReadLine();
                bool check1 = library.SearchByAuthor(name1);
                Console.WriteLine(check1);
                if (check1 == true)
                {
                    Console.WriteLine("Do you want to check this book out? y/n");
                    string respond = Console.ReadLine().ToLower().Trim();
                    if (respond == "y")
                    {
                        Console.WriteLine($"your due date is:");
                        library.CreateDueDate();
                    }
                    else
                    {
                        Console.WriteLine($"We do not currently have any books by {name1}");
                    }
                }

            }


            library.DisplayList();

            Console.WriteLine();
            Console.WriteLine("Enter your choice name/title/checkout");
            string choice1 = Console.ReadLine();
            if (choice == "name")
            {
                Console.WriteLine("Enter the author  name to search");
                string name1 = Console.ReadLine();
                library.SearchByAuthor(name1);
               
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
