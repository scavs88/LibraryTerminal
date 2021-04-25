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
            Console.WriteLine("Enter your choice name/title");
            string choice = Console.ReadLine();
            if (choice == "name")
            {
                Console.WriteLine("Enter the author  name to search");
                string name = Console.ReadLine();
                bool check1 = library.SearchByAuthor(name);
                Console.WriteLine(check1);
                if (check1 == true)
                {
                    Console.WriteLine("Do you want to check out?");
                    string respond = Console.ReadLine().ToLower().Trim();
                    if(respond == "y")
                    {
                        Console.WriteLine($"your due date is:");
                        library.CreateDueDate();
                    }
                    else
                    {

                    }
                }

            }

            
            


           


            Console.WriteLine("Enter the author  name to search");
            string name = Console.ReadLine();
            bool check1 = library.SearchByAuthor(name);
            Console.WriteLine(check1);
            //bool


            //Book book = new Book("Jim Harrison", "Woman Lit by Fireflies", false, 14);
            //Console.WriteLine(book);

            //StreamWriter writer = new StreamWriter("../../../testfile.txt");
            //writer.WriteLine("Hi test");
            //writer.Close();
            library.CreateDueDate();

        }
    }
}
