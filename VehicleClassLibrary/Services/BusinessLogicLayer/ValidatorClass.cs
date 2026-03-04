using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Services.BusinessLogicLayer
{
    public class ValidatorClass
    {
        public static string GetValidString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Error: Input cannot be empty or whitespace. Please try again.\n");
            }
        }
    }
}
