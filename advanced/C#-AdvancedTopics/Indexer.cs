//Indexers
//makes working with lists, dictionaries and collections
//its an easier way to access items 

using System.Diagnostics;

public class Indexer
{
    private readonly Dictionary<string, string> _dictionary;

    //create an indexer method using this[Type key]
    public string this[string key]
    {
        get { return _dictionary[key]; }
        //get method returns the value of the item according to the key provided
        set { _dictionary[key] = value; }
        //set value of item in key
    }

    public Indexer()
    {
        _dictionary = new Dictionary<string, string>();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var indexer = new Indexer();
        indexer["name"] = "jonas";
        //"indexer of name equals jonas"
        //"indexer" could be anything, like an HttpCookie for instance

        Console.WriteLine(indexer["name"]);
    }
}