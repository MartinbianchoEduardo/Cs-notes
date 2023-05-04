namespace Lectures
{
    public class Customer
    {
        public int Id;
        public string Name;
        //the readonly keyword makes sure that only one instance of this will be made
        //if we try to initialize another List of orders, we'll get an error in the IDE
        public readonly List<Order> Orders = new List<Order>();
        //whenever you have a class, with a list attribute like the one above
        //always initialize that list as an empty list 

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) //delegate the control to the other constructor above
        {
            this.Name = name;
        }

        public void Promote()
        {
            Console.WriteLine("Customer promoted");
        }
    }
}
