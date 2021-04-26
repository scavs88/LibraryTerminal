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
            new Book("Dr.Suess","The cat in the Hat",true,""),
            new Book("Jhumpa Lahiri", "Interpreter of Maladies" , true ,""),
            new Book("Jim Harrison", "Woman Lit by Fireflies", false, "5/14/21"),
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
            foreach (Book book in this._books)
            {
                if (book.Author == input)
                {
                    status = true;
                    Console.WriteLine(book);
                }
            }
            if (!status)
            {

                    Console.WriteLine(" That book is not available");                

                

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


        public void SearchByTitle(string input)

        {
            bool status = false;
            foreach (Book book in this._books)
            {
                if (book.Title == input)
                {
                    Console.WriteLine("Yes the book is available");
                    status = true;
                }
            }

        }

        public void SearchByKeyword(string input)
        {
            foreach (Book word in this._books)
            {
                if (word.Title == input)
                {
                    Console.WriteLine($"We found {word.ToString()}");
                }
                else
                {
                    Console.WriteLine($"There was no book with {word} in any title.");
                }
            }
        }

        public void SearchByKyword(string input)
        {
            Book books = new Book();
            for (int i = 0; i < _books.Count; i++)
            {
                foreach (Book word in this._books)
                {
                    if (books.Title.Contains(input))
                    {
                        Console.WriteLine($"We found {word.ToString()}");
                    }
                    else
                    {
                        Console.WriteLine($"There was no book with {word} in any title.");
                    }
                }              
            }
        }
    }
}



