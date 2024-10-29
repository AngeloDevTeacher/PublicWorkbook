/// <summary>
/// Learning about variable scope and multiple parameters.
/// Author: Angelo Encarnacion
/// Date Modified: 2024-10-29
/// </summary>
/// 

string name = "Angelo Encarnacion";


string ExclaimCatName(string temporaryCatNamePlaceholder)
{
    return temporaryCatNamePlaceholder+"!";
}


Console.WriteLine(ExclaimCatName("Sully"));


void SpellUpTo(string word, int number)
{
	for (int i = 0; i < number; i++)
	{
        Console.WriteLine(word[i]);
    }
    
}

string word = "Example";
int number = 24;
SpellUpTo("Kyle M Henderson", 9);
SpellUpTo("Chris D Malone", 4);

Console.WriteLine(word);
Console.WriteLine(number);