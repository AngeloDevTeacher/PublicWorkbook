string[] rainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

string[] myCopyOfRainbow;

int cash = 100;
int myCash = 0;

myCash = cash;
myCash += 1;

myCopyOfRainbow = rainbowColors;
for (int i = 0; i < 7; i++)
{
    myCopyOfRainbow[i] = myCopyOfRainbow[i].ToUpper();
    Console.WriteLine(rainbowColors[i]);
}