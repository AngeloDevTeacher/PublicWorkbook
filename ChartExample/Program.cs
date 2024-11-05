


// Can I make a grid, starting my y and the bottom (or largest y at the top)

const int Height = 12;
const int Width = 10;

int place = 1;

// This will count from left to right, from "bottom to top".
for (int h = Height-1; h >= 0; h--)
{
    for (int w = 1; w <= Width; w++)
    {
        Console.Write($"{w + (h * 6)}\t");
        place++;
    }
    Console.WriteLine();
    
}

Console.WriteLine();
Console.WriteLine();

// This will count from left to right, from "bottom to top".
for (int h = Height - 1; h >= 0; h--)
{
    for (int w = 1; w <= Width; w++)
    {
        if (w == 1)
        {
            Console.Write($"{h}\t");
        }
        else if (h == 0)
        {
            Console.Write($"{w}\t");
        }
        else
        {
            Console.Write($" \t");
        }

        place++;
    }
    Console.WriteLine();

}


Console.WriteLine();
Console.WriteLine();
int[] moneyMade = new int[Width];
moneyMade[1] = 546;

// Put something within the grid system
for (int h = Height - 1; h >= 0; h--)
{
    for (int w = 1; w <= Width; w++)
    {
        if (w == 1)
        {
            Console.Write($"{h*50+"|",8}\t");
        }
        else if (h == 0)
        {
            Console.Write($"{w}\t");
        }
        else if (w > 1)
        {
            if ((h * 50) > moneyMade[w-1] && ((h - 1) * 50) <= moneyMade[w-1])
            {
                Console.Write($"${moneyMade[w-1]}\t");
            }
            else
            {
                Console.Write($" \t");
            }
            
        }

        place++;
    }
    Console.WriteLine();

}

