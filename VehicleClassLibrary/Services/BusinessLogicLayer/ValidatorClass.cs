using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VehicleClassLibrary.Services.BusinessLogicLayer
{
    public class ValidatorClass
    {
        /// <summary>
        /// Checks the users entry to make sure it's not an empty string
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        public static string GetValidString(string entry)
        {
            // Enter a while loop to ensure we get a valid entry
            while (true)
            {
                Console.Write(entry);
                // Grab the string input from the user
                string? input = Console.ReadLine();

                // Use try catch to check that the input is a valid string and not null or empty
                try
                {
                    // Check if the input is null or empty space
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        // If so, throw an exception
                        throw new ArgumentException("Please enter an entry with a string");
                    }
                    // Return the input cleared
                    return input.Trim();
                }
                // Catch if the input is not a valid string
                catch (ArgumentException ex)
                {
                    // If so, write the error message to the user
                    Console.WriteLine("Please enter a valid entry");
                }
                // Catch any other unexpected exceptions
                catch (Exception ex)
                {
                    Console.WriteLine("Unkown error, please input a correct entry");
                }
            }
        }

        /// <summary>
        /// Checks the users entry to make sure it's not an empty string and only contains letters or related characters
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        public static string GetValidLettersOnlyString(string entry)
        {
            // Enter a while loop to ensure we get a valid entry
            while (true)
            {
                // Prompt the user for input
                Console.Write(entry);
                // Grab the string input from the user
                string? input = Console.ReadLine();

                // Use try catch to check that the input is a valid string and not null or empty and only contains letters or related characters
                try
                {
                    // Check if the input is null or empty space
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        // If so, throw an exception
                        throw new ArgumentException("Not a valid string (cannot be empty).");
                    }
                    // Trim the input to remove any whitespace
                    input = input.Trim();

                    // Check if the input contains only letters or related characters
                    foreach (char c in input)
                    {
                        // Check if the character is not a letter or related characters
                        if (!(char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-' || c == '\''))
                        {
                            // If so, throw an exception
                            throw new FormatException();
                        }
                    }
                    // Return the input if it is valid
                    return input;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid string using only letters\n");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Please enter a valid string using only letters\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error, please enter a valid string using only letters\n");
                }
            }
        }

        /// <summary>
        /// Checks the users entry to make sure it's a valid integer and ensure it is within a given range if specified
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetValidInt(string entry, int? min = null, int? max = null)
        {
            // Enter a while loop to ensure we get a valid entry
            while (true)
            {
                // Prompt the user for input
                Console.Write(entry);
                // Grab the string input from the user
                string? input = Console.ReadLine();

                // Use try catch to check that the input is a valid integer and not null or empty and within the specified range if given
                try
                {
                    // Check if the input is null or empty space
                    if (string.IsNullOrWhiteSpace(input))
                    {   
                        // If so, throw an exception
                        throw new FormatException();
                    }
                    // Parse the input to an integer
                    int value = int.Parse(input);
                    // Check if the value is less than the minimum if a minimum is specified
                    if (min.HasValue && value < min.Value)
                    {
                        // If so, throw an exception
                        throw new ArgumentOutOfRangeException(nameof(value), $"Number must be less than or equal to {min.Value}.");
                    }
                    // Check if the value is greater than the maximum if a maximum is specified
                    if (max.HasValue && value > max.Value)
                    {
                        // If so, throw an exception
                        throw new ArgumentOutOfRangeException(nameof(value), $"Number must be greater than or equal to {max.Value}.");
                    }
                    // Return the value if it is valid
                    return value;
                }
                // Catch if the input is not a valid integer
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number\n");
                }
                // Catch if the input is a number but too large or too small to fit in an integer
                catch (OverflowException)
                {
                    Console.WriteLine("Given number was either too small or too big, please try again\n");
                }
                // Catch if the input is a valid integer but not within the specified range
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Given number was either too small or too big, please try again\n");
                }
                // Catch any other unexpected exceptions
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error, please try again with a valid number");
                }
            }
        }

        /// <summary>
        /// Checks the users entry to make sure it's a valid decimal
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static decimal GetValidDecimal(string entry, decimal? min = null, decimal? max = null)
        {
            // Enter a while loop to ensure we get a valid entry
            while (true)
            {
                // Prompt the user for input
                Console.Write(entry);
                // Grab the string input from the user
                string? input = Console.ReadLine();

                // Use try catch to check that the input is a valid decimal and not null or empty and within the specified range if given
                try
                {
                    // Check if the input is null or empty space
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        // If so, throw an exception
                        throw new FormatException();
                    }
                    // Parse the input to a decimal
                    decimal value = decimal.Parse(input);
                    // Return the value if it is valid
                    return value;
                }
                // Catch if the input is not a valid decimal
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid decimal value\n");
                }
                // Catch any other unexpected exceptions
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error, please enter a valid value\n");
                }
            }
        }

        /// <summary>
        /// Checks the users entry to make sure it's a valid boolean
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        public static bool GetValidBool(string entry)
        {
            // Enter a while loop to ensure we get a valid entry
            while (true)
            {
                // Prompt the user for input
                Console.Write(entry);
                // Grab the string input from the user
                string? input = Console.ReadLine();

                // Use try catch to check that the input is a valid boolean and not null or empty
                try
                {
                    // Check if the input is null or empty space
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        // If so, throw an exception
                        throw new FormatException();
                    }
                    // Parse the input to a boolean and return it if it is valid
                    return bool.Parse(input);
                }
                // Catch if the input is not a valid boolean
                catch (FormatException)
                {
                    Console.WriteLine("Please answer with true or false\n");
                }
                // Catch any other unexpected exceptions
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error, please answer with true or false\n");
                }
            }
        }
    }
}