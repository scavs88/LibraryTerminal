using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Jim Harrison", "Woman Lit by Fireflies", false, 14);
            Console.WriteLine(book);

            //StreamWriter writer = new StreamWriter("../../../testfile.txt");
            //writer.WriteLine("Hi test");
            //writer.Close();

        }
    }
}
