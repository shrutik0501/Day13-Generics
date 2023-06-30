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
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber");
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ThirdNumber");
            int thirdvalue = Convert.ToInt32(Console.ReadLine());
            int val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            Console.WriteLine("{0} is largest number ", val);
            Console.ReadLine();
        }
    }
}
