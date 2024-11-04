
// These are the very basic patterns of reading and writing files.
string fileName = "test.csv";
bool appendToFile = true;

StreamWriter writer = new StreamWriter($"../../../{fileName}", appendToFile);
writer.WriteLine("Bulbasaur, Lvl 21");
writer.WriteLine("Pikachu, Lvl 2");
writer.Close();

StreamReader reader = new StreamReader($"../../../{fileName}");
string line; 
for (int i = 0; i < 6; i++)
{
    line = reader.ReadLine();
    Console.WriteLine(line);
}
reader.Close();