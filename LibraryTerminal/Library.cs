using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Library
    {
        //field
        private List<Book> _books = new List<Book>
        {
            new Book("Dr. Seuss","The Cat in the Hat",true,""),
            new Book("Jhumpa Lahiri", "Interpreter of Maladies" , true ,""),           
            new Book("Jim Harrison", "Woman Lit by Fireflies", false, "5/14/2021"),
            new Book("Leslie Orchard", "Hacking RSS and Atom", true, ""),
            new Book("Christian Klaver", "Shadows Over London", true, ""),
            new Book("Esther Averil", "Jenny and the Cat Club", false,  "5/7/2021"),
            new Book("Anthony Bourdain", "Kitchen Confidential", false, "5/8/2021"),
            new Book("Grant Achatz", "Life on the Line", true, ""),
            new Book("Bill Bryson", "Walk in the Woods", false, "5/10/2021"),
            new Book("William Shakespeare", "Comedy of Errors", true, ""),
            new Book("Elizabeth Haydon", "Rhapsody", true, ""),
            new Book("John Feinstein", "Last Amateurs", true, ""),

        };



        //property
        public List<Book> Books
        {
            get { return this._books; }
            set { this._books = value; }
        }
        //Constructor
        public Library()
        {

        }

        //methods

        public void DisplayList()
        {
            foreach (Book books in this._books)
            {
                Console.WriteLine(books.ToString());
            }
        }
        public void CreateDueDate()
        {
            var date = DateTime.Now.AddDays(14);

            var dateShort = date.ToShortDateString();
            Console.WriteLine($"The due date is { dateShort}");

        }

        public bool SearchByAuthor(string input)
        {
            bool status = false;
            bool found = false;
            foreach (Book book in this._books)
            {               
                if (book.Author == input && book.Status == true)
                {
                    status = true;
                    found = true;
                    Console.WriteLine(string.Format("{0, -20} {1, -30} {2, -16} {3, -16}", "Author", "Title", "On shelf", "Due date"));
                    Console.WriteLine(string.Format("{0, -20} {1, -30} {2, -16} {3, -16}", "======", "=====", "========", "========"));
                    Console.WriteLine(book);
                    break;
                }
                else if (book.Author == input && book.Status == false)
                {
                    found = true;
                    Console.WriteLine(book);
                    Console.WriteLine("That book is not available for check out.");                   
                }                
            }
            if (found == false)
            {
                Console.WriteLine("That was not a valid author.");              
            }
            return status;
        }

        public void Checkout(string input)
        {
            bool status = false;
            foreach (Book book in this._books)
            {
                if (book.Title.ToLower().Trim() == input)
                {
                    status = true;
                }
            }

            if (status)
            {
                Console.WriteLine("Yes the book is available");
                CreateDueDate();               
            }
            else
            {
                Console.WriteLine(" That book is not available");
            }
        }


       

        public void SearchByKeyword(string input)
        {

            for (int i = 0; i < _books.Count; i++)
            {
                if (this._books[i].Title.ToLower().Trim().Contains(input))
                {                  
                    Console.WriteLine($"{this._books[i].ToString()}");
                }
            }
        }


        public void ReturnBook()
        {

            Console.WriteLine("Enter the title of the book to return");
            string title1 = Console.ReadLine().Trim().ToLower();
            bool status1 = false;
            foreach (Book book in this._books)
            {
                if (book.Title.ToLower().Trim() == title1 && book.Status == false)
                {

                    book.Status = true;
                    status1 = true;

                }
            }
            if (status1 == true)
            {
                Console.WriteLine("You returned the book successfully ");
            }

            else
            {
                Console.WriteLine("This book has not been checked out");
            }



        }

    }

}




