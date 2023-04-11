using System;

namespace Loops_Jefferson
{
    class Program
    {
        /// <summary>
        /// Asks the user two different question records there’s two responses and put the responses in two different sentence
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("why do you want to make games?");
            string response = Console.ReadLine();

            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            Console.WriteLine("Please enter a whole number!");
            string response2 = Console.ReadLine();

            Console.WriteLine($"The sum of the indivdual digits of {response2} is {SumOfDigits(response2)}!");
;        }
        /// <summary>
        /// counts the numbers of spaces
        /// </summary>
        /// <param name="sentence">The sentance to count number of spaces in</param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                    numberOfSpaces++;
            }

            return numberOfSpaces;
        }
        /// <summary>
        /// finds the sum 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }

            return sum;
        }
    }
}
