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
            int num = 6, num_one = 7, num_two = 8;
            float dec = 3.3f, dec_one = 7.5f, dec_two = 0.7f;
            string word = "Sai", word_one = "Satya", word_Two = "Zee";
            Maximum<int> maximum = new Maximum<int>(num, num_one, num_one);
            int values = maximum.MaxMethod();
            Console.WriteLine("{0} is the largest", values);
            Maximum<float> maximum_one = new Maximum<float>(dec, dec_one, dec_two);
            float values_one = maximum_one.MaxMethod();
            Console.WriteLine("{0} is the largest", values_one);
            Maximum<string> maximum_two = new Maximum<string>(word, word_one, word_Two);
            string values_two = maximum_two.MaxMethod();
            Console.WriteLine("{0} is the largest", values_two);

            Console.ReadLine();
        }
    }
}