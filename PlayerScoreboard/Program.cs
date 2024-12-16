using PlayerScoreboard;

/// <summary>
/// Create a database of players who play towerfall story mode.
/// Author: Angelo Encarnacion
/// Last Modified: 2024-12-10
/// </summary>
/// 

// Variables
string firstName;
string lastName;
int plays;
double score;

string option;

// Saving pt 1


// Program intro
// I'm lazy not doing it in class

// Make sure you loop here or in prompt to get a valid string for names. 
do
{
    firstName = Prompt("Please enter first name:\t");
    if (string.IsNullOrEmpty(firstName))
    {
        Console.WriteLine("Please enter in a valid first name");
    }
    
} while (string.IsNullOrEmpty(firstName));

lastName = Prompt("Please enter last name:\t");
plays = PromptInt("Please enter amount of plays:\t");
score = PromptDouble("Please enter lifetime score:\t");

Player example = new Player(firstName, lastName, plays, score);

Console.WriteLine();
Console.WriteLine("\tPlayer Details\t");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine($"{"Player Name:",20} {example.FirstName} {example.LastName}");
Console.WriteLine($"{"Play Count:",20} {example.PlayCount}");
Console.WriteLine($"{"Lifetime Score:",20} {example.LifetimeScore}");

Console.WriteLine();
option = Prompt("Would you like to see [A]vg score, player [L]evel, or [B]oth:");
if (option.ToUpper()[0] == 'A')
{
    Console.WriteLine($"The average score of the player is: {example.AverageScore}");
}
else if (option.ToUpper()[0] == 'L')
{
    Console.WriteLine($"The the player level is: {example.PlayerLevel}");
}
else if (option.ToUpper()[0] == 'B')
{
    Console.WriteLine($"The average score of the player is: {example.AverageScore}");
    Console.WriteLine($"The the player level is: {example.PlayerLevel}");
}


/// <summary>
/// Prompts the user, returns a string.
/// </summary>
static string Prompt(string messageToUser)
{
    Console.Write(messageToUser);
    return Console.ReadLine();
}


/// <summary>
/// Prompts the user, looping until a valid int is provided. No rules apply.
/// </summary>
static int PromptInt(string message)
{
    int output = 0;
    bool valid = false;
    do
    {
        try
        {
            Console.Write(message);
            output = int.Parse(Console.ReadLine());
            valid = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter a valid whole number.");
        }
    } while (valid == false);
    return output;
}

/// <summary>
/// Prompts the user, looping until a valid double is provided. No rules apply.
/// </summary>
static double PromptDouble(string message)
{
    double output = 0;
    bool valid = false;
    do
    {
        try
        {
            Console.Write(message);
            output = double.Parse(Console.ReadLine());
            valid = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter a valid whole number.");
        }
    } while (valid == false);
    return output;
}