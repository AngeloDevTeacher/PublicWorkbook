
// These are the very basic patterns of reading and writing files.
string fileName = "test.angelosave";
bool appendToFile = true;

try
{
    StreamWriter writer = new StreamWriter($"../../../{fileName}", appendToFile);

    writer.WriteLine("Bulbasaur, Lvl 21");
    writer.WriteLine("Pikachu, Lvl 2");
    writer.Close();
}
catch (Exception ex)
{
	// Put a msg.
}


try
{
    StreamReader reader = new StreamReader($"../../../{fileName}");
    string line;
    while (!reader.EndOfStream)
    {
        line = reader.ReadLine();
        Console.WriteLine(line);
    }
    reader.Close();
}
catch (Exception)
{

	//put a msg.
}

Console.WriteLine("DONE");