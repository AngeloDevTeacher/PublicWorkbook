// The core of arrays is dealing with similar data in a nice way.
//string catName = "Sully";
//string catName2 = "Piper";
//string catName3 = "Mike";


//Console.WriteLine(catName);
//Console.WriteLine(catName2);
//Console.WriteLine(catName3);

// We have something called an array - it holds a collection of similar data.

// This example is an empty array.
// USeful to know, we don't use it often at all.
string[] catNames = { };

// This is an "intialized array of strings.
// Not used commonly in this class.
string[] angeloCatsNames = { "Sully", "Piper", "Mike", "Max", "Mickey", "Lily", "Albert Whiskers", "Scarlet", "Tango" };



// This is a array with a set size
// The most common usage in this class.
// We want to use a CONSTANT variable to describe the max size.
int MaxCatsPerHousehold = 5;
string[] catsInAHousehold = new string[MaxCatsPerHousehold];

// This is an example of efficient code for the commented section line 2 to line 9 above, using the array on line 19.
//for (int i = 0; i < angeloCatsNames.Length; i++)
//{
//    Console.WriteLine(angeloCatsNames[i].ToUpper());
//}

// Arrays have a SET SIZE after being set, it CANNOT change.
// IF you try to change it, you are actually making a NEW array.
// Variables
int catsInHouse = 0;
string userInput = "";
// Program Purpose
Console.WriteLine("--Cat Register--");
Console.WriteLine();


// We use a do-while loop to run at least ONCE.
do
{
    // Prompt
    Console.WriteLine("Enter a cat name, or a blank entry to finish.");
    Console.Write("Enter a cat name: ");
    // Set the userInput to the ReadLine so we can use logic!
    // We DON'T want to add an empty string OR increase the count IF the line was blank.
    userInput = Console.ReadLine();
    if (userInput != string.Empty)
    {
        // Set the current cat in the array.
        // Remember, we are using a variable to keep track of the cats. We also will increment the variable on sucess.
        catsInAHousehold[catsInHouse] = userInput;
        catsInHouse++;
    }
    // We want to be able to exit the loop if the string was empty OR if we reached the max.
} while (userInput != string.Empty && catsInHouse < MaxCatsPerHousehold);

// We are using the "LOGICAL SIZE" - the size of the data we inputted.
// If there are 3 cat names in the 5 length array, the array has a PHYSICAL SIZE/ length of 5, but a LOGICAL size of 3
for (int i = 0; i < catsInHouse; i++)
{
    Console.WriteLine(catsInAHousehold[i]);
}

