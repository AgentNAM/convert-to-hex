using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToHex("hello world"));
            Console.WriteLine(ConvertToHex("Big Boi"));
            Console.WriteLine(ConvertToHex("Marty Poppinson"));

            Console.ReadKey();
        }

        static string ConvertToHex(string str)
        {
            string hexStr = "";

            foreach (char c in str)
            {
                hexStr += BitConverter.ToString(BitConverter.GetBytes(c)).Trim('0').Trim('-').ToLowerInvariant() + " ";
            }

            hexStr = hexStr.Trim();

            return hexStr;
        }
    }
}
