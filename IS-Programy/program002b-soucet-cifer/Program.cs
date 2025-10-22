string again = "a";
while (again == "a")
{


    Console.WriteLine("*********************************************");
    Console.WriteLine("************** Součet cifer *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 16.10.2025 *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();


    Console.Write("Zadejte číslo: ");
        string vstup = Console.ReadLine();

        int soucet = 0;

        foreach (char znak in vstup)
        {
            if (char.IsDigit(znak))
            {
                soucet += int.Parse(znak.ToString());
            }
        }

        Console.WriteLine("Součet cifer: " + soucet);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}