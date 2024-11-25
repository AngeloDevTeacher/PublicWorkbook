/// <summary>
/// GOAL: Read a CSV with header data in the top row.
/// Author: Angelo Encarnacion
/// Date Modified: 2024/11/18
/// </summary>
/// 
const int MaxSize = 25;
string fileName = "test.csv";
int count = 0;

string[] pokemonName = new string[MaxSize];
int[] pokemonLevel = new int[MaxSize];  

StreamReader reader = new StreamReader($"../../../{fileName}");
string line;
while (!reader.EndOfStream)
{
    line = reader.ReadLine();
    if(count > 0)
    {
        string[] items = line.Split(",");

        pokemonName[count-1] = items[0];
        pokemonLevel[count-1] = int.Parse(items[1]);
    }
    count++;
    //Console.WriteLine(line);
}
reader.Close();
Console.WriteLine("DONE1");