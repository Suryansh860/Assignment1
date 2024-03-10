using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class LambdaQuery_2
    {
        static void Main(string[] args)
        {
            //Taking user input words which is seperated by commas....
            Console.WriteLine("Enter the words seperated by commas:");
            string s = Console.ReadLine();

            //Spliting the input string into an array of words....
            string[] words = s.Split(',');

            //Query to filtering the words which is starting with 'a' and ending with 'm'.....
            var Result = words.Where(word => word.Trim().StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.Trim().EndsWith("m", StringComparison.OrdinalIgnoreCase));

            //Printing the Output...

            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var word in Result)
            {
                Console.WriteLine(word.Trim());
            }
            Console.ReadLine();
        }
    }
}
