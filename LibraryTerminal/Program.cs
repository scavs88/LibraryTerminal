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
            
            //prompt to search here
            while (true)
            {
                Console.WriteLine("Please select a search function");
                Console.WriteLine("To see our entire inventory enter 1");
                Console.WriteLine("To search by author enter 2");
                Console.WriteLine("To search by title enter 3");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    library.DisplayList();
                    break;
                }
                else if (choice == 2)
                {
                    //implement author search method here
                    break;
                }else if (choice == 3)
                {
                    //implement title search
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }





            //ask for a selection here




            //Book book = new Book("Jim Harrison", "Woman Lit by Fireflies", false, 14);
            //Console.WriteLine(book);

            //StreamWriter writer = new StreamWriter("../../../testfile.txt");
            //writer.WriteLine("Hi test");
            //writer.Close();
            
        }
    }
}
