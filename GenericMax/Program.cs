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
            Console.WriteLine("Enter the FirstNumber");
            string firstvalue = Console.ReadLine();
            Console.WriteLine("Enter the SecondNumber");
            string secondvalue = Console.ReadLine();
            Console.WriteLine("Enter the ThirdNumber");
            string thirdvalue = Console.ReadLine();
            string val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            Console.WriteLine("{0} is largest number ", val);
            Console.ReadLine();
        }
    }
}
