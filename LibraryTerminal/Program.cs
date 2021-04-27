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
            bool runProgram = true;
            int choice;
            bool userInput = false;
            while (runProgram)
            {
                Console.WriteLine("Please select a menu item");
                Console.WriteLine("1.) Display library inventory.");
                Console.WriteLine("2.) Search for a book by author");
                Console.WriteLine("3.) Search for a book by title/keyword");
                Console.WriteLine("4.) Checkout book");
                Console.WriteLine("5.) Return a book");
                
                try                    
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine(string.Format("{0, -20} {1, -30} {2, -16} {3, -16}", "Author", "Title", "On shelf", "Due date"));
                        Console.WriteLine(string.Format("{0, -20} {1, -30} {2, -16} {3, -16}", "======", "=====", "========", "========"));
                        library.DisplayList();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter the author name to search");
                        string name1 = Console.ReadLine();
                        
                        bool check1 = library.SearchByAuthor(name1);
                        //Console.WriteLine(check1);
                        
                        if (check1 == true)
                        {                            
                            Console.WriteLine("Do you want to check this book out? y/n");                            
                            string respond = Console.ReadLine().ToLower().Trim();
                            if (respond == "y")
                            {
                                Console.WriteLine($"your due date is:");
                                library.CreateDueDate();
                            }
                            else if (respond == "n")
                            {
                                Console.WriteLine("We'll put that title back on the shelf.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("That was an invalid entry");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"We do not currently have any books by {name1}");
                        }
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Enter a keyword to search for");
                        string input = Console.ReadLine();
                        Console.WriteLine("We found");
                        library.SearchByKeyword(input);
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Enter the title of the book you would like to checkout");
                        string checkTitle = Console.ReadLine().Trim().ToLower();
                        library.Checkout(checkTitle);
                    }
                    else if (choice == 5)
                    {
                        library.ReturnBook();
                    }
                    else if (choice <= 0 || choice > 5)
                    {
                        Console.Clear();
                        Console.WriteLine("That was not a menu option.  Please choose an option between 1 - 5");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("That was not a menu option.  Please try again.");
                    continue;
                }
                while (true)
                {
                    Console.WriteLine("\nDo you want to continue? y/n");
                    string keepGoing = Console.ReadLine().ToLower().Trim();
                    if (keepGoing == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (keepGoing == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }

                }
            }
        }
    }
}
//StreamWriter writer = new StreamWriter("../../../testfile.txt");
//writer.WriteLine("Hi test");
//writer.Close();