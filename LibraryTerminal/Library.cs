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
            new Book("Jim Harrison", "Woman Lit by Fireflies", false, "5/14/21")

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
        public string CreateDueDate()
        {
            var date = DateTime.Now.AddDays(14);

            var dateShort = date.ToShortDateString();
            Console.WriteLine(dateShort);
            return dateShort;
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
                    Console.WriteLine(" That book is not avaiable");                
            }
            return status;
        }

        public void Checkout(string input)
        {
            bool status = false;
            foreach (Book book in this._books)
            {
                if (book.Author == input)
                {
                    status = true;

                }
            }

            if (status)
            {
                Console.WriteLine("Yes the book is avaiable");
                string date = CreateDueDate();
                Console.WriteLine($"your due date is: {date}");

            }
            else
            {
                Console.WriteLine(" That book is not avaiable");
            }
        }


        public void SearchByTitle(string input)

        {
            //bool status = false;
            foreach (Book book in this._books)
            {
                if (book.Title == input)
                {
                    Console.WriteLine("Yes the book is avaiable");
                    //status = true;
                }
            }
           
        }
        public void ReturnBook()
        {
            Console.WriteLine("Enter the title of the book to return");
            string title1 = Console.ReadLine().Trim().ToLower();
            foreach(Book book in this._books)
            {
                if (book.Title.ToLower().Trim() == title1)
                {
                    book.Status = true;                    
                }
            }
            Console.WriteLine("You retured the book successfuly ");
        } 
    }


}



