using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title t = new Title();
            Author a = new Author();
            Content c = new Content();
            Book.Show();
            Console.ReadKey();
        }
    }
    class Book
    {
        static public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
    class Title
    {
        static public string title;
        static Title()
        {
            Console.WriteLine("Name the title: ");
            title = Convert.ToString(Console.ReadLine());
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Title: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
        }
    }
    class Author
    {
        static public string author;
        static Author()
        {
            Console.WriteLine("Name of the author: ");
            author = Convert.ToString(Console.ReadLine());
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Author of this book: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
        }
    }
    class Content
    {
        static public string content;
        static Content()
        {
            Console.WriteLine("What is the content of this book?");
            content = Convert.ToString(Console.ReadLine());
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The content of this book is: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(content);
        }
    }
}
