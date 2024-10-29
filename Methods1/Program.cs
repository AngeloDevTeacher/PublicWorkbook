/// <summary>
///  Write a program to tally up total change from user’s pockets. The method GetTotal() will have
///  number of pennies, nickels, dimes, quarters, loonies and twoonies passed into it and will return the
///  total amount. All values entered must be integers and positive. Validation is required to ensure a
///  negative value is not allowed.
/// Author: Angelo Encarnacion
/// Date Modififed: 2024-10-29
/// </summary>
/// 

double GetTotal()
{
    double output = 0;

    return output;
}

// Helper method: GetCoin
int GetCoin(string textCoinPrompt)
{
    int coin = 0;
	string userInput = "";
	bool validCoinCount = false;
	// Prompt pattern, with validation
	do
	{
        try
        {
            Console.Write(textCoinPrompt);
            userInput = Console.ReadLine();
            coin = int.Parse(userInput);
            if (coin > 0)
            {
                validCoinCount = true;
            }
            else
            {
                validCoinCount = false;
                Console.WriteLine("You must enter a positive number.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("You must enter a whole number.");
        }
    } while (!validCoinCount);

    return coin;
}

int test = GetCoin("Enter in the amount of pennies\t");
Console.WriteLine(test);