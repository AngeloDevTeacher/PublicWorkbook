/// <summary>
/// Learn about lists and for each
/// Author: Angelo Encarnacion
/// Date Modified: 2024-12-05
/// </summary>
/// 

// What is a list?
// A list is a resizable collection! It has an accurate count of exactly how many things are in it!
// Lists have a lot of shortcomings, but are easy to use if you have good code flow.






const int MaxCount = 25;

List<string> listOfStrings = new List<string>();
string[] arrayOfStrings = new string[MaxCount];

Console.WriteLine(arrayOfStrings.Length);
Console.WriteLine(listOfStrings.Count);

// To add something to my list
listOfStrings.Add("Hello world");
Console.WriteLine(listOfStrings.Count);

// To remove something from the list:
listOfStrings.Remove("Hello world");
Console.WriteLine(listOfStrings.Count);


listOfStrings.Add("A");
listOfStrings.Add("BB");
listOfStrings.Add("CCC");
listOfStrings.Add("DDDD");

for (int i = 0; i < listOfStrings.Count; i+=2)
{
    if (i > 0)
    {
        Console.WriteLine(listOfStrings[i].ToUpper());
    }
    
}

foreach (string item in listOfStrings)
{
    Console.WriteLine(item.ToUpper());
}

foreach (char letter in "Jacob")
{
    Console.WriteLine(letter);
}

listOfStrings.Clear();
Console.WriteLine(listOfStrings.Count);

