using C__Intermediate;

namespace Lectures
{


    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);

            Car car = new Car("rara");
            car.Move(10, "here");
            Console.WriteLine(car.Axis);
        }
    }
}
