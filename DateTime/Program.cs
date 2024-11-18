DateTime today = DateTime.Now;

Console.WriteLine(today.DayOfWeek);

string dateToParse = "";
Console.Write("Enter a date in this format(MM/DD/YYYY):\t");
dateToParse = Console.ReadLine();

DateTime parsedDate = DateTime.Parse(dateToParse);
Console.WriteLine(parsedDate);