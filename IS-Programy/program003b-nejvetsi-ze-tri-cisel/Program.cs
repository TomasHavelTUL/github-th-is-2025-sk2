using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{


    Console.WriteLine("*********************************************");
    Console.WriteLine("*********** Nejvetsi ze 3 cisel *************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 23.10.2025 *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();


    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte znovu celé číslo A: ");
    }


    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte znovu celé číslo B: ");
    }


    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte znovu celé číslo C: ");
    }

    Console.WriteLine();
    Console.WriteLine("=======================================");


    if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine($"Nejvetsi cislo je A ={a}");
        }
        else
        {
            Console.WriteLine($"Nejvetsi cislo je C = {c}");
        }

    }
    else
    {
        if (b > c)
        {
            Console.WriteLine($"Nejvetsi cislo je B = {b}");
        }
        else
        {
            Console.WriteLine($"Nejvetsi cislo je C = {c}");
        }

    }








    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}