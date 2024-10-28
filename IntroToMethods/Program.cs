/// < summary>
/// Introduce basic methods.
/// Angelo Encarnacion
/// Date Modified: 2024-10-28
/// </summary>
/// 

// _ r _ _ p t

// This is a method
// It has a signature:
// - return type (string here, or void if none)
// - method name (TitleCase)
// - Parameters, if any. MUST HAVE parenthesis.
string Prompt(string text)
{
    // Inside the method is the method body.
    Console.Write(text);
    return Console.ReadLine();
}

string name = "";
name = Prompt("Please enter a name\t");
Console.WriteLine(name);

string friendName = "";
friendName = Prompt("Please enter your friends name\t");
Console.WriteLine(friendName);

int PromptInt(string text)
{
    bool validInput = false;
    int output = 0;
    do
    {
        try
        {
            string userInput = "";
            Console.Write(text);
            userInput = Console.ReadLine();
            output = int.Parse(userInput);
            validInput = true;
        }
        catch (Exception)
        {
            validInput = false;
            Console.WriteLine("Please enter a whole number.\t");
        }
    } while (!validInput);
    return output;
}

int[] myCatsAges = new int[5];
for (int i = 0; i < myCatsAges.Length; i++)
{
    myCatsAges[i] = PromptInt("Please enter an age");
}
for (int i = 0; i < myCatsAges.Length; i++)
{
    Console.WriteLine(myCatsAges[i]);
}

void DisplayMainMenu()
{
    Console.WriteLine("MENU");
    Console.WriteLine();
    Console.WriteLine("[E]nter a name:");
    Console.WriteLine("[D]isplay a name:");
    Console.WriteLine("E[X]it program");
}


while (true)
{
    DisplayMainMenu();
}


