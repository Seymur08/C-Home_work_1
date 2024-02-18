// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
void concole(int secim)
{
    if (secim == 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[ + ]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.Write("[ - ]");
        Console.Write("\t");
        Console.Write("[ * ]");
        Console.Write("\t");
        Console.Write("[ / ]");
        Console.Write("\t");
        Console.Write("[ % ]");
    }


    else if (secim == 1)
    {
        Console.Clear();
        Console.Write("[ + ]");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[ - ]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.Write("[ * ]");
        Console.Write("\t");
        Console.Write("[ / ]");
        Console.Write("\t");
        Console.Write("[ % ]");

    }


    else if (secim == 2)
    {
        Console.Clear();
        Console.Write("[ + ]");
        Console.Write("\t");
        Console.Write("[ - ]");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[ * ]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.Write("[ / ]");
        Console.Write("\t");
        Console.Write("[ % ]");
    }


    else if (secim == 3)
    {
        Console.Clear();
        Console.Write("[ + ]");
        Console.Write("\t");
        Console.Write("[ - ]");
        Console.Write("\t");
        Console.Write("[ * ]");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[ / ]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\t");
        Console.Write("[ % ]");
    }

    else if (secim == 4)
    {
        Console.Clear();
        Console.Write("[ + ]");
        Console.Write("\t");
        Console.Write("[ - ]");
        Console.Write("\t");
        Console.Write("[ * ]");
        Console.Write("\t");
        Console.Write("[ / ]");
        Console.Write("\t");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[ % ]");
        Console.ForegroundColor = ConsoleColor.White;
    }

}


void Screen(int secim, double num_1, double num_2)
{
    Console.WriteLine("\n");
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("For Choice ( < and > ) + Enter");
    Console.WriteLine();

    switch (secim)
    {

        case 0:
            Console.WriteLine($"{num_1} + {num_2} = {num_1 + num_2}");
            break;

        case 1:
            Console.WriteLine($"{num_1} - {num_2} = {num_1 - num_2}");
            break;

        case 2:
            if (num_1 != 0 && num_2 != 0)
                Console.WriteLine($"{num_1} * {num_2} = {num_1 * num_2}");

            else Console.WriteLine("cannot be divided by zero");

            break;

        case 3:
            if (num_1 != 0 && num_2 != 0)
                Console.WriteLine($"{num_1} / {num_2} = {(double)num_1 / num_2}");

            else Console.WriteLine("cannot be divided by zero");
            break;
        case 4:
            if (num_1 != 0 && num_2 != 0)
                Console.WriteLine($"{num_1} % {num_2} = {(double)num_1 / 100 * num_2}");

            else Console.WriteLine("cannot be divided by zero");
            break;

    }

    Console.ForegroundColor = ConsoleColor.White;


}

double num_1;
Console.Write("Enter number 1 - ");
bool check_1 = double.TryParse(Console.ReadLine(), out num_1);

double num_2;

Console.Write("Enter number 2 - ");
bool check_2 = double.TryParse(Console.ReadLine(), out num_2);

ushort secim = 0;

while (check_1 && check_2)
{

    concole(secim);

    Screen(secim, num_1, num_2);

    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.RightArrow)
    {
        if (secim == 4) secim = 0;

        else secim++;

    }


    else if (key.Key == ConsoleKey.LeftArrow)
    {
        if (secim == 0) secim = 4;

        else secim--;

    }

    else if (key.Key == ConsoleKey.Enter)
        break;

    else
        Console.WriteLine("please make the right choice!");


}

Console.WriteLine("please Enter Number!");
