using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            string city;
            string state;
            string zip;
            string tshirts;
            double amount;


            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Street Address: ");
            address = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            Console.Write("Zip: ");
            zip = Console.ReadLine();
            Console.Write("How many T-Shirts do you want to order? ");
            tshirts = Console.ReadLine();
            amount = Convert.ToDouble(tshirts);
            Console.WriteLine();
            Console.WriteLine();

            double total = amount * 14.99;
            double tax = total * 0.08;
            double due = tax + total;

            Console.WriteLine("Receipt for: ");
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine($"{city}, {state} {zip}");
            Console.WriteLine();
            Console.WriteLine(tshirts + " T-Shirts ordered @ 14.99 each");
            Console.WriteLine("Total: $" + total.ToString("F2"));
            Console.WriteLine("Tax:   $" + tax.ToString("F2"));
            Console.WriteLine("---------------");
            Console.WriteLine("Due:   $" + due.ToString("F2"));
        }
    }
}
