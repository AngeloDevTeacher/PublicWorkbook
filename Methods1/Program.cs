/// <summary>
///  Write a program to tally up total change from user’s pockets. The method GetTotal() will have
///  number of pennies, nickels, dimes, quarters, loonies and twoonies passed into it and will return the
///  total amount. All values entered must be integers and positive. Validation is required to ensure a
///  negative value is not allowed.
/// Author: Angelo Encarnacion
/// Date Modififed: 2024-10-29
/// </summary>
/// 

double myMoney = 0;
myMoney = GetTotal();
Console.WriteLine($"{myMoney:c}");

double GetTotal()
{
    double output = 0;
    int pennies, nickels, dimes, quarters, loonies, twoonies;
    pennies = GetCoin("How many pennies do you have?\t");
    nickels = GetCoin("How many nickels do you have?\t");
    dimes = GetCoin("How many dimes do you have?\t");
    quarters = GetCoin("How many quarters do you have?\t");
    loonies = GetCoin("How many loonies do you have?\t");
    twoonies = GetCoin("How many twoonies do you have?\t");

    output = (pennies * 0.01) + (nickels * 0.05) + (dimes * 0.10) + (quarters * 0.25) + (loonies * 1.00) + (twoonies * 2.00);

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


