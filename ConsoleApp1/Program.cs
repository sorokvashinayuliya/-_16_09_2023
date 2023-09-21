using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   

 
    public static class StringExtensions
    {
        public static int Count(this string input, string substr)
        {
            return Regex.Matches(input, substr).Count;
        }
    }

    public class Example
    {
        public static void Main()
        {
            string input = "Hello World";

            int freq = input.Count("l");

            Console.WriteLine(freq);        // 3
        }
    }

    
        
}

