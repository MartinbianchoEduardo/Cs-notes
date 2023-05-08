namespace C__AdvancedTopics
{
    public class Generics
    {

    }

    //could create a GenericList but generally an existing one is used
    //but the generic list would be like this:
    public class GenericList<T> //T fot Type (any type)
    {
        public void Add(T value)
        {

        }

        public T this[int index]
            //return is of type T
        {
            get { throw new NotImplementedException(); }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            var book = new Book(1, "title");

            var numbers = new GenericList<int>();
            numbers.Add(1); //note that the parameter for Add() is of type int

            var books = new GenericList<Book>();
            books.Add(book); //note that the parameter fot Add() is of type Book

            //see all generics in c#
            //System.Collections.Generic.
        }
    }

    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Book(int Id, string Title)
        {
            this.Id = Id;
            this.Title = Title;
        }
    }
}
