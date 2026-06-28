using VehicleClassLibrary.Services.BusinessLogicLayer;

/*
 * Elijah Hodge
 * CST - 250
 * 06/27/2026
 * Vehicle Class Library
 * Activity 1
 */

//--------------------------------------------------------
// Start of the Main Method
//--------------------------------------------------------

// Print a welcome message to the user

Console.WriteLine("Welcome to the Vehicle Shop! To begin, please create a selection " +
    "of vehicles and add them to the inventory. Once the inventory if populated, you can " +
    "proceed by adding vehicles to your cart. Finally, when you're ready to complete " +
    "your purchase, proceed to the checkout where your total bill will be calculated.");

// Read an integer input from user
static int ReadChoice()
{
    // Declare and initialize
    // Set input as a nullable reference type
    string? input = "";
    int choice = -1;

    // Loop until the user enters a valid choice
    while (choice == -1)
    {
        // Print the users options
        Console.Write("Choose an action: \n0) Quit \n1) Print the inventory \n2) Print the shopping cart \n3)" +
        "Create a vehicle \n4) Add a vehicle to the shopping cart \n5) Checkout \n6) Save inventory to a test" +
        "file \n7) Load inventory from a text file \nInput: ");

        // Read the user input from the console
        input = Console.ReadLine();
        // Make sure the user entered a value
        if (!string.IsNullOrEmpty(input))
        {
            try
            {
                // Parse the input from the user to the choice variable
                choice = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a valid number. The number entered was either too small or too " +
                    "large.");
            }
            catch (Exception exp)
            {
                Console.WriteLine("There was an exception " + exp + ". Please try again.");
            }
        }
    }
    // Return the users input
    return choice;
}

//--------------------------------------------------------
// End of the Main Method
//--------------------------------------------------------