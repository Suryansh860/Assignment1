using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testcase("abcd"));
            Console.WriteLine(testcase("a"));
            Console.WriteLine(testcase("xy"));
            Console.ReadLine();
        }
        public static string testcase(string str1)
        {
            return str1.Length > 1 ? str1.Substring(str1.Length - 1) + str1.Substring(1, str1.Length - 2) + str1.Substring(0, 1) : str1;
        }
    }

}

