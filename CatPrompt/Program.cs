/// <summary>
/// Purpose: This program asks for your name and amount of cats to display to the user.
/// Author: Angelo Encarnacion angeloe@nait.ca
/// Date Modified: 2024-09-10
/// </summary>

// ************* When I declare, I say: ********************
// - The variable is of type (so put the type first)
// - name the variable according to our standards (no spaces, camelCase, descriptive)
// - End with a semicolon.
// - Optional: We can assign it a value to start.
// **********************************************************

// Make a user input variable
string userInput = "";

// Declare nameOfPerson as String
string nameOfPerson = string.Empty;
// Declare amountOfCats as Integer
int amountOfCats;

// *********** When I ASSIGN (set) a value: ********************
// - Use the name (the type should already be set!)
// - put a single equal sign "=" to say "it is" 
// - Give it a value of the correct type! (if the variable was a int, give it an int value.)
// - End with a semicolon.
// **********************************************************

// Set amountOfCats = 0
amountOfCats = 0;

// Prompt "Please enter your name: " nameOfPerson
Console.Write("Please enter your name: ");
userInput = Console.ReadLine();

// If I had some processing, I could do it before setting the value of nameOfPerson
nameOfPerson = userInput.Trim();

// Prompt "Please enter a whole number for the amount of cats you have: " amountOfCats
Console.Write("Please enter a whole number for the amount of cats you have: ");
userInput = Console.ReadLine();
amountOfCats = int.Parse(userInput);

// Display nameOfPerson " has " amountOfCats "cat(s)"
Console.WriteLine($"{nameOfPerson} has {amountOfCats} cat(s)!");