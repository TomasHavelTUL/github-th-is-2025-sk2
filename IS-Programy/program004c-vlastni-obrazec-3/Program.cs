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

Console.Write("Zadejte pocet radku: ");
int radky;
while (!int.TryParse(Console.ReadLine(), out radky) || radky < 1)
{
    Console.Write("Nezadali jste cele cislo. Zadejte pocet radku znovu: ");
}

Console.Write("Zadejte pocet hvezdicek v radku: ");
int sloupce;
while (!int.TryParse(Console.ReadLine(), out sloupce) || sloupce < 1)
{
    Console.Write("Nezadali jste cele cislo. Zadejte pocet hvezdicek znovu: ");
}

for (int i = 0; i < radky; i++)
{
    if (i % 2 == 0)
        Console.Write(" ");

    for (int j = 0; j < sloupce; j++)
    {
        Console.Write("* ");
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(80));
    }

    Console.WriteLine();
}




        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
