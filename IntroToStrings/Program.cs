/// <summary>
/// Intro to strings.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-10-01
/// </summary>


// A string is a collection of characters.
string teachersName = "Angelo Encarnacion";
string output = "";

// Methods are instructions that apply to the thing we're working with
// We can say <thing>.<instruction> to apply it to itself.

// Strings have methods. For example, we can set the name to all lower case.:
Console.WriteLine($"The string {teachersName} is {teachersName.ToLower()} in lowercase.");

// Print out in all uppercase.
Console.WriteLine($"The string {teachersName} is {teachersName.ToUpper()} in uppercase.");

// We can grab the length
Console.WriteLine($"The length of {teachersName} is {teachersName.Length}.");

// We can grab a single character of a string. The first item is at position 0.
Console.WriteLine($"The first letter of {teachersName} is {teachersName[0]}.");

// An index tells you WHERE in a collection something is located. Indexes start at 0.
Console.WriteLine($"The position of \"A\" in {teachersName} is {teachersName.IndexOf("A")}.");

// First time a sequence appears
Console.WriteLine($"The position of \"car\" in {teachersName} is {teachersName.IndexOf("car")}.");

// We can check for a occurance AFTER an index:
Console.WriteLine($"The position of \"a\" after index 12 in {teachersName} is {teachersName.IndexOf("a", 12)}.");

// We can check to see if a letter exists in a string.
Console.WriteLine($"The letter \"A\" in {teachersName} exists? {teachersName.Contains("A")}.");

// We can also grab a substring:
Console.WriteLine($"The substring starting at position 7  in {teachersName} is {teachersName.Substring(7)}.");

// We can be more specific and give a start and end:
Console.WriteLine($"The 3 character substring starting at position 7  in {teachersName} is {teachersName.Substring(7,3)}.");

// to get the last letter of a name:
Console.WriteLine($"The last letter of {teachersName} is {teachersName[teachersName.Length - 1]}.");