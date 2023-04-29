using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecToMin
{
    internal class SecToMin
    {
        static void Main(string[] args)
        {
            int userInput;
            int minutes;
            int remainderSeconds;

            Console.WriteLine("Please enter the amount of seconds you wish to convert: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            minutes = userInput / 60;
            remainderSeconds = userInput % 60;

            if (remainderSeconds < 10)
            {
                Console.WriteLine("{0} seconds is {1}:0{2} ({1} minutes 0{2} seconds).",userInput, minutes, remainderSeconds);
            }
            else
            {
                Console.WriteLine("{0} seconds is {1}:{2} ({1} minutes {2} seconds).", userInput, minutes, remainderSeconds);
            }
        }
    }
}
