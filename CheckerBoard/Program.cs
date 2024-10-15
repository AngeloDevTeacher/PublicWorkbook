/// <summary>
/// Purpose: Use a nested loop to make shapes.
/// Author: Angelo Encanracion
/// Date Modified: 2024-10-10
/// </summary>
/// 

int shapeAWidth = 22;
int shapeAHeight = 14;

string shapeALetter = "X";
string emptyALetter = "O";

// USE A FOR LOOP TO MAKE A SQUARE of X's using WIDTH and HEIGHT


for (int y = 0; y < shapeAHeight; y++)
{
    for (int x = 0; x < shapeAWidth; x++)
    {
        if (x % 2 == y % 2)
        {
            Console.Write(shapeALetter);
        } 
        else
        {
            Console.Write(emptyALetter);
        }
    }
    Console.WriteLine();
}   

