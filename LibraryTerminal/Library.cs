using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Library
    {
        //field
        private List<Book> _book = new List<Book>
        {
            new Book("Dr.Suess","The cat in the Hat",true,""),
            new Book("Jhumpa Lahiri", "Interpreter of Maladies" , true ,""),
            new Book("Jim Harrison", "Woman Lit by Fireflies", false, "5/14/21")

        };

        
        //property
        public List<Book> Book
        {
            get { return this._book; }
            set { this._book = value; }
        }
        //Constructor
        public Library()
        {

        }

        //methods

        public void DisplayList()
        {
            foreach(Book books in this._book)
            {
                Console.WriteLine(books.ToString());
            }
        }


        public void KeywordSearch()
        {
            foreach (Book word in title)
            {
                bool keyword = true;
                while (keyword)
                if (word == Library.)
            }
        }


        public void CreateDueDate()
        {
            var date = DateTime.Now.AddDays(14); 
            var dateShort = date.ToShortDateString();
            Console.WriteLine(dateShort);
        }

        public  bool SearchByAuthor(string input)
        {
            bool status = false;
            foreach(Book book in this._book)
            {
                if (book.Author == input)
                {
                    Console.WriteLine("Yes the book is avaiable");
                    status= true;
                }

            }
            return status;
        }

        public bool SearchByTitle(string input)
        {
            bool status = false;
            foreach (Book book in this._book)
            {
                if (book.Title == input)
                {
                    Console.WriteLine("Yes the book is avaiable");
                    status = true;
                }

            }
            return status;
        }

        //public void 


    }
}
