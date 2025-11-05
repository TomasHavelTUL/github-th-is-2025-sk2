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

Console.Write("Zadejte vysku pismene N: ");
int height;
while (!int.TryParse(Console.ReadLine(), out height))
{
    Console.Write("Nezadali jste cele cislo. Zadejte vysku znovu: ");
}

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < height; j++)
    {
        if (j == 0 || j == height - 1 || j == i)
            Console.Write("*");
        else
            Console.Write(" ");
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(80));
    }
    Console.WriteLine();
}


        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
