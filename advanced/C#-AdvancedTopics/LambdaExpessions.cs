using System.Reflection;

namespace C__AdvancedTopics
{

    //Lambda Expressions are anonymous functions 
    //used for convenience

    //syntax: args => expression
    //"args 'goes to' expression"
    class LambdaExpessions
    {
        static void main(String[] args) {

            //use delegates
            //Func<argument , return type>

            Func<int, int> square = Square;

            //both of these are the same 

            Func<int, int> square = n => n * n;

            Console.WriteLine(square(5));
        }

        static int Square(int n)
        {
            return n * n;
        }
    }
}
