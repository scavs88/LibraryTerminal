using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Book
    {
        //fields
        private string _author;
        private string _title;
        private bool _status;
        private int _duedate;

        //properties
        public string Author
        {
            get { return this._author; }
            set { this._author = value; }
        }

        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public bool Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        public int Duedate
        {
            get { return this._duedate; }
            set { this._duedate = value; }
        }
        //constructor
        public Book(string author, string title, bool status, int duedate)
        {
            this._author = author;
            this._title = title;
            this._status = status;
            this._duedate = duedate;
        }

        //override method
        public override string ToString()
        {
            string formattedList = string.Format("{0, -15} {1, -16} {2, -16} {3, -16}", this._author, this._title, this._status, this._duedate);           
            return formattedList;
        }

        //DateTime duedate = DateTime.Now; // will give the date for today
        //string dateWithFormat = duedate.ToLongDateString();
    }
}
