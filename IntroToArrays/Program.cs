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
for (int i = 0; i < angeloCatsNames.Length; i++)
{
    Console.WriteLine(angeloCatsNames[i].ToUpper());
}

