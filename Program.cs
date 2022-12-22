
using IntermediaryConstructors;

//Constructor is a method that is called when an instance of class is created.
//We use constructors to put an object in an early state.
namespace IntermediaryConstructors
{
     public class Program
    {
        static void Main(string[] args)
        { 
           //instatiating costumer class
           var customer = new Customer(1, "Jhon");
           Console.WriteLine(customer.Id);
           Console.WriteLine(customer.Name);

           //instatiating order class
           var order = new Order();
           customer.Orders.Add(order);
        }
    }
}