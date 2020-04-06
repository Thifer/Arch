using System;
using System.Linq;

namespace Lesson1
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Customer customer = new Customer();
            Store store = new Store();
            Console.Write($"{customer.Id},{store.Id}");
        }
    }
}
