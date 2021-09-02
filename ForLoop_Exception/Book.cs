using System;
using System.Collections.Generic;
using System.Text;

namespace ForLoop_Exception
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //constructor
        /*
        public Book()
        {
            Console.WriteLine("Creating Book");  //prints Creating Book for every book object I make
        }

        public Book(string name)
        {
            Console.WriteLine(name);//now it expects a string when initializing a Book object
        }
        */

        public Book (string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public Book()
        {
            //allows you to set up the book by manually adding the title, author and pages separately
        }
    }

}
