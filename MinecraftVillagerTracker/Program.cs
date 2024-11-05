/// <summary>
/// Track the name, job, and $ a villager has.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-11-04
/// </summary>


// Variables
bool isProgramRunning = true;
string userInput = "";
char menuChoice;

// Make a "temp" memory structure - an array
const int MaxNumberOfVillagers = 25;

// Parallel arrays = the data at the same position SHOULD BE RELATED.
string[] villagerNames = new string[MaxNumberOfVillagers];
string[] villagerJobs = new string[MaxNumberOfVillagers];
int[] villagerCash = new int[MaxNumberOfVillagers];


// MAIN PROGRAM START
do
{
    DisplayMenu();
    menuChoice =  MenuPrompt("Choose a menu option");

    switch (menuChoice)
    {
        case 'D':
            int loadedNumber = LoadVillagersFromFile("villagers.csv", villagerNames, villagerJobs, villagerCash);
            for (int i = 0; i < loadedNumber; i++)
            {
                Console.WriteLine($"{villagerNames[i]}: {villagerJobs[i]}, {villagerCash[i]}");
            }
            break;
        case 'X':
            isProgramRunning = false;
            break;
        default:
            break;
    }
} while (isProgramRunning);


// Shows menu options
static void DisplayMenu()
{
    Console.WriteLine("[D]isplay Villagers");
    Console.WriteLine("[A]dd Villager Data");
    Console.WriteLine("[R]emove a Villager"); // Might not be done today/might be extra
    Console.WriteLine("[E]dit a Villager");
    Console.WriteLine("E[X]it");
}

static int LoadVillagersFromFile(string fileName, string[] names, string[] jobs, int[] cash)
{
    int output = 0;
    StreamReader reader = new StreamReader("../../../"+fileName);
    string line;
    while (!reader.EndOfStream)
    {
        line = reader.ReadLine();
        string[] items = line.Split(",");
        names[output] = items[0];
        jobs[output] = items[1];
        cash[output] = int.Parse(items[2]);
        output++;
    }
    return output;
} 

// Grabs a string from the user.
static string Prompt(string message)
{
    Console.Write(message+"\t");
    return Console.ReadLine();
}

// Grabs a menu option from the user.
static char MenuPrompt(string message)
{
    Console.Write(message + "\t");
    return Console.ReadLine().ToUpper()[0];
}