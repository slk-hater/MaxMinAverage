using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinAverage
{
    class Program
    {
        static void Main()
        {
            int numberofValues, lowestValue=0, highestValue=0, sum=0, value;
            string input;
            Console.Title = "Minimum, maximum and average - Guilherme Fadário";
            do
            {
                Console.Write("How many numbers you want to insert? ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out numberofValues));
            for (int loop = 1; loop <= numberofValues; loop++)
            {
                do
                {
                    Console.Write($"Insert your {loop} number: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out value));
                sum += value;
                if(loop == 1) 
                {
                    highestValue = value;
                    lowestValue = value;
                }
                else
                {
                    if (value > highestValue) highestValue = value;
                    else if (value < lowestValue) lowestValue = value;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("According to the numbers inserted:");
            Console.WriteLine($"The lowest number was: {lowestValue}");
            Console.WriteLine($"The highest number was: {highestValue}");
            Console.WriteLine($"The average of all numbers is: {Convert.ToDecimal(sum)/Convert.ToDecimal(numberofValues)}");
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}//by Gui1herme#8721
