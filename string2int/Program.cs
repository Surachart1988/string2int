using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> collection = new string[] { "abc573", "a5b7c3", "abc 573", "-abc573", "ABC573", "aah72gv82g7gv7828cedc" };

            foreach (var input in collection)
            {
                int number = 0;
                foreach (char c in input)
                {
                    if (c >= '0' && c <= '9') // accept only numeric characters
                    {
                        number *= 10;
                        number += c - '0'; // convert ascii to digit 0..9 and add it to number 
                    }
                }
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
