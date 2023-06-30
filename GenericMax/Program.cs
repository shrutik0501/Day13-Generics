using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maximum maximum = new Maximum();

            Console.WriteLine("Please Enter the FirstValue:");
            var val = Console.ReadLine();
            Console.WriteLine("Please Enter the SecondValue:");
            var val_one = Console.ReadLine();
            Console.WriteLine("Please Enter the ThirdValue:");
            var val_two = Console.ReadLine();

            var Value = maximum.Number(val, val_one, val_two);
            Console.WriteLine("{0} is greater", Value);
            Console.ReadLine();
        }
    }
}

