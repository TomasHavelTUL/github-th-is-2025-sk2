using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{


    Console.WriteLine("*********************************************");
    Console.WriteLine("******* Vykresleni vlastniho obrazce ********");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 5.11.2025 *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();

Console.Write("Zadejte velikost diamantu (polovinu vysky): ");
int size;
while (!int.TryParse(Console.ReadLine(), out size) || size < 2)
{
    Console.Write("Nezadali jste platne cislo (min. 2). Zadejte velikost znovu: ");
}

int height = size * 2;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < height; j++)
    {
        if (j == Math.Abs(size - 1 - i) || j == height - Math.Abs(size - 1 - i) - 1)
            Console.Write("*");
        else
            Console.Write(" ");
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
    }
    Console.WriteLine();
}



        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
