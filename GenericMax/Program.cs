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
            double firstvalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber");
            double secondvalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the ThirdNumber");
            double thirdvalue = Convert.ToDouble(Console.ReadLine());
            double val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            Console.WriteLine("{0} is largest number ", val);
            Console.ReadLine();
        }
    }
}
