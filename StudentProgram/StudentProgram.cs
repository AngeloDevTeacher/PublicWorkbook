/// <summary>
/// Make a student and display the data
/// Author: Angelo Encarnacion angeloe@nait.ca
/// Date Modified: 2024-11-28
/// </summary>
using StudentExample;

// Variable
bool programRun = true;
string firstName, lastName;
int id;
Console.WriteLine();

Console.WriteLine("Student Tracker Display");

do
{
    firstName = Prompt("Please enter a first name\t");
    lastName = Prompt("Please enter a last name\t");
    do
    {
        id = PromptInt("Please enter in a student id\t");
    } while (id < 0);

    Student thisStudent = new Student(firstName, lastName, id);
    Console.WriteLine(thisStudent.ToString());
    // Check to see if we continue?
    if (Prompt("Do you want to continue[y/n]").ToLower() != "y")
    {
        programRun = false;
    }
} while (programRun);

// Helper Methods

/// <summary>
/// Prompts the user, returns a string.
/// </summary>
static string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

/// <summary>
/// Returns a int from a prompt, will loop until a valid input is given.
/// </summary>
static int PromptInt(string message)
{
    int output = 0;
	bool validInput = false;
	do
	{
        try
        {
            Console.Write(message);
            output = int.Parse(Console.ReadLine());
            validInput = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter a valid whole number.");
        }
    } while (!validInput);
    return output;
}