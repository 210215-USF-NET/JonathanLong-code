
using System;
using System.Collections.Generic;
namespace PredicatesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer List
            List<Customer> customers = new List<Customer>();

            //Add new customers
            Customer c1 = new Customer();
            c1.Name = "David";
            c1.PhoneNumber = 1234567899;
            Customer c2 = new Customer();
            c2.Name = "Liz";
            c2.PhoneNumber = 1234567899;

            //Add customers to List
            customers.Add(c1);
            customers.Add(c2);

            //Use Predicate to find if employee name is in the list
            Console.WriteLine("Search for a customer name: ");
            string customerName = Console.ReadLine();
            Predicate<Customer> nameFinder = (Customer c) => {return c.Name == customerName;};
            try
            {
            Console.WriteLine("The name " + customers.Find(nameFinder).Name + " has been found");
            }
            catch{
                throw new Exception("No records have been found");
            }
            

        }
    }
}
