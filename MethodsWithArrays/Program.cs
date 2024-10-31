string[] rainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

string[] myCopyOfRainbow;

int cash = 100;
int myCash = 0;

myCash = cash;
myCash += 1;
// This line sets myCopy's address to the same as rainbowColors.
//myCopyOfRainbow = rainbowColors;

// Do this to make a new set of data to edit! This also sets myCopy to that address, so I won't have the same mistake!
myCopyOfRainbow = new string[rainbowColors.Length];
rainbowColors.CopyTo(myCopyOfRainbow, 0);

for (int i = 0; i < 7; i++)
{
    myCopyOfRainbow[i] = myCopyOfRainbow[i].ToUpper();
    Console.WriteLine(rainbowColors[i]);
}