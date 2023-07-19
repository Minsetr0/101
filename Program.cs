int health = 0;
int maxHealth = 10;
int mana = 0;
int maxMana = 10;
int healthBarPosition = 0;
int manaBarPosition = 1;
char empty = '_';
int playerCursorPosition = 5;
ConsoleColor healthBarColor = ConsoleColor.Red;
ConsoleColor manaBarColor = ConsoleColor.Blue;

while (true)
{
    DrawBar(health, maxHealth, healthBarPosition, empty, healthBarColor);
    DrawBar(mana, maxMana, manaBarPosition, empty, manaBarColor);

    Console.SetCursorPosition(0, playerCursorPosition);

    Console.Write("Введите процент жизней:");

    health = FillingBar(maxHealth);

    Console.Write("Введите процент маны:");

    mana = FillingBar(maxMana);

    Console.Clear();
}
static void DrawBar(int value, int maxValue, int barPosition, char symbol, ConsoleColor barColor)
{
    ConsoleColor defaultColor = Console.BackgroundColor;
    string bar = "";
    char leftSideBar = '[';
    char rightSideBar = ']';

    for (int i = 0; i < value; i++)
    {
        bar += symbol;
    }

    Console.SetCursorPosition(0, barPosition);
    Console.Write(leftSideBar);
    Console.BackgroundColor = barColor;
    Console.Write(bar);
    Console.BackgroundColor = defaultColor;
    int occupied = bar.Length;

    bar = "";

    for (int i = 1; i <= (maxValue - occupied); i++)
    {
        bar += symbol;
    }

    Console.Write(bar + rightSideBar);
}

static int FillingBar(int maxContainers)
{
    int numberToDivide = 10;
    int filledСells;
    int maxPercent = 100;
    int minPercent = 0;
    int percentToConvert = Convert.ToInt32(Console.ReadLine());

    if (percentToConvert > minPercent && percentToConvert < maxPercent)
    {
        filledСells = percentToConvert / numberToDivide;
    }
    else if (percentToConvert >= maxPercent)
    {
        filledСells = maxContainers;
    }
    else
    {
        filledСells = 0;
    }
    
    return filledСells;
}