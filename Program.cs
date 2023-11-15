bool inputAgain = true;
while (inputAgain)
{
    Console.Write("Enter the value of N: ");
    int nValue = int.Parse(Console.ReadLine());
    for (int i = 1; i <= nValue; i++)
    {
        if (i % 5 == 0 && i != 5)
        {
            Console.Write("AERO ");
        }
        else if (i % 6 == 0 && i != 6)
        {
            Console.Write("ASYST ");
        }
        else
        {
            Console.Write($"{i} ");
        }
    }
    Console.WriteLine();
    Console.Write("Again? (y/n) ");
    inputAgain = Console.ReadLine() == "y" ? true: false;
}