using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class LambdaQuery_1
    {
        static void Main(string[] args)
        {
            //taking user input which is seperated by commas...
            Console.WriteLine("Enter numbers by seperating them commas:");
            string s = Console.ReadLine();

            //Split the input string by commas and converting each part into an Integer....
            int[] numbers = s.Split(',').Select(int.Parse).ToArray();

            //Selecting the square of each number and filtering those numbers which are greater than 20
            var result = numbers.Select(n => n * n).Where(square => square > 20);

            //Displaying the Result or Numbers (which are greater than 20)

            Console.WriteLine("Square greater than 20: ");
            foreach (var square in result)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();
        }
    }
}
