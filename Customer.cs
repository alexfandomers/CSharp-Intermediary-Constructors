using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediaryConstructors
{
    public class Customer
    {
       public int Id;
       public string Name;
       public List<Order> Orders;

       //Declaring a constructor
       public Customer() // in this constructor orders will be initialized but will be null on the oders ones.
       {
            Orders = new List<Order>();
       }
       public Customer(int id)
            : this() //this means when we call this constructor we initialize orders from the first constuctor
                     //We can pass control from one constructor to the other by using the this keyword.
       {
            this.Id = id;
       }
       public Customer(int id, string name)
            : this(id) //this means when we call this constructor we initialize orders from the second constuctor
       {
            //this.Id = id;
            this.Name = name;
       }
    }
}