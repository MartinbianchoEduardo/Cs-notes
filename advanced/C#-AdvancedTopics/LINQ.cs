﻿using System.Linq;

namespace C__AdvancedTopics
{

    //Language Integrated Query

    //query objects in memory (linq to objects), databases (linq to entities), xml 
    class LINQ
    {
        static void main(String[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ QUERY OPERATORS
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            //query operators always start with 'from' and end with 'select'

            //these are equivalent


            //LINQ EXTENSION METHODS
            //display a list of books cheaper than $10 using LINQ
            //where method
            var cheapBooks = books.Where(b => b.Price < 10);

            books.OrderBy(b => b.Title).Select(b => b.Title);

            //these methods can be chained
            //var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title);
        }

    }

    public class Book1
    {
        public string Title { get; set; }
        public float Price { get; set; }s
    }

    //list of books
    class BookRepository
    {
        public IEnumerable<Book1> GetBooks()
        {
            return new List<Book1>()
            {
                new Book1() {Title = "book 1", Price = 12.99f},
                new Book1() {Title = "book 2", Price = 2.99f},
                new Book1() {Title = "book 3", Price = 1.99f},
                new Book1() {Title = "book 4", Price = 120.99f},

            };
        }
    }
}

