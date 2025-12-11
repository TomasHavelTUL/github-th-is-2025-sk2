﻿string again = "a";
while (again == "a")
{


    razitko();
    ulong a = nactiCislo("Zadejte cislo a: ");
    ulong b = nactiCislo("Zadejte cislo b: ");









    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();





    static void razitko()
    {
        Console.WriteLine("********************************************");
        Console.WriteLine("*********** NSD a NSN *************");
        Console.WriteLine("********************************************");
        Console.WriteLine("********************************************");
        Console.WriteLine("************* Tomáš Havel ******************");
        Console.WriteLine("************** 11.12.2025 *******************");
        Console.WriteLine("********************************************");
        Console.WriteLine("********************************************");
        Console.WriteLine();
    }


    static ulong nactiCislo(string zprava)
    {
        Console.Write("Zadejte první číslo řady (celé číslo): ");
        ulong cislo;
        while (!ulong.TryParse(Console.ReadLine(), out cislo))
        {
            Console.Write("Nezadali jste prirozene číslo. Zadejte vstup znovu: ");
        }

        return cislo;
    }

 






}