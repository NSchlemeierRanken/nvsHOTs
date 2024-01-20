using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string intOne;
            //string intTwo;
            //string intThree;
            //double one;
            //double two;
            //double three;

            Console.Write("Enter your first number: ");
            double one = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your second number: ");
            double two = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your third number: ");
            double three = Convert.ToDouble(Console.ReadLine());

            double sum = one + two + three;
            Console.WriteLine("The sum of those three numbers is " + sum);

            double average = sum / 3;
            Console.WriteLine("The average of those three numbers is " + average);
        }
    }
}
