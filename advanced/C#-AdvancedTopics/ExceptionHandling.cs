namespace C__AdvancedTopics
{
    internal class ExceptionHandling
    {

        static void main(string[] args)
        {
            var Calculator = new Calculator();

            try
            {
            Console.WriteLine(Calculator.Divide(5, 0));

            } catch (Exception ex)
            {
                throw new CalculatorException("calculator went wrong", ex);
            }
        }

    }

    //custom exception creation
    public class CalculatorException : Exception { 
    public CalculatorException(string message, Exception InnerException) 
            : base(message, InnerException)
        {}
    }

    public class Calculator
    {
        public Calculator() { }

        public float Divide(int num, int den)
        {
            return num / den;
        }
    }
}
