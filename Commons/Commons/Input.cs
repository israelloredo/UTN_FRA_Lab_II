using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commons
{
    public class Input
    {
        public static int numberInt(String message, string errorMessage)
        {
            int number = 0;
            bool valid = false;
            string input;

            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                valid = int.TryParse(input, out number);
                if (!valid)
                {
                    Console.WriteLine(errorMessage);
                }
            }
            while (!valid);

            return number;
        }
    }
}
