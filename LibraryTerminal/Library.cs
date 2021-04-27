﻿using System;
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
            new Book("Jim Harrison", "Legends of the Fall", true, ""),
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

            int counter = 1;
            foreach (Book books in this._books)
            {
                Console.WriteLine($"{counter}. {books.ToString()}");
                counter++;
            }
        }
        public string CreateDueDate()
        {
            var date = DateTime.Now.AddDays(14);

            var dateShort = date.ToShortDateString();
            Console.WriteLine($"The due date is { dateShort}");
            return dateShort;
        }

        public bool SearchByAuthor(string input)
        {
            bool status = false;
            Console.WriteLine(string.Format("{0, -6}  {1, -23} {2, -30} {3, -16} {4,-15}", "No.", "Author", "Title", "On shelf", "Due date"));
            Console.WriteLine(string.Format("{0, -6}  {1, -23} {2, -30} {3, -16} {4,-15}", "===", "======", "=====", "========", "========"));
            int counter = 1;
            foreach (Book book in this._books)
            {

                if (book.Author == input)
                {
                    status = true;
                    Console.WriteLine($"{counter}. {book}");
                    counter++;
                }

            }
            return status;
        }

        public void Checkout(string input)
        {
            bool status = false;
            for (int i = 0; i < _books.Count; i++)
            {
                if (_books[i].Title.ToLower().Trim() == input && _books[i].Status == true)
                {
                    status = true;
                    this._books[i].Status = false;
                    Console.WriteLine($"You have checked out '{input}' ");
                    this._books[i].Duedate = CreateDueDate();


                }
            }
            if (!status)
            {
                Console.WriteLine(" That book is not available");
            }
        }




        public List<Book> SearchByKeyword(string input)
        {

            List<Book> titleList = new List<Book>();
            for (int i = 0; i < _books.Count; i++)
            {
                if (this._books[i].Title.ToLower().Trim().Contains(input))
                {
                    titleList.Add(this._books[i]);
                    //Console.WriteLine($"{this._books[i].ToString()}");
                }
            }
            int counter = 1;
            Console.WriteLine(string.Format("{0, -6}  {1, -23} {2, -30} {3, -16} {4,-15}", "No.", "Author", "Title", "On shelf", "Due date"));
            Console.WriteLine(string.Format("{0, -6}  {1, -23} {2, -30} {3, -16} {4,-15}", "===", "======", "=====", "========", "========"));
            foreach (Book book in titleList)
            {
                Console.WriteLine($"{counter}. {book.ToString()}");
                counter++;
            }
            return titleList;

        }


        public void ReturnBook()
        {

            Console.WriteLine("Enter the title of the book to return");
            string title1 = Console.ReadLine().Trim().ToLower();
            bool status1 = false;
            for (int i = 0; i < this._books.Count; i++)
            {
                if (this._books[i].Title.ToLower().Trim() == title1 && _books[i].Status == false)
                {

                    this._books[i].Status = true;
                    this._books[i].Duedate = " ";
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




