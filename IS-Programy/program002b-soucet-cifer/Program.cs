string again = "a";
while (again == "a")
{


    Console.WriteLine("*********************************************");
    Console.WriteLine("************** Součet cifer *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 23.10.2025 *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();


Console.Write("Zadejte číslo: ");
string vstup = Console.ReadLine();

int soucet = 0;
int soucin = 1;
bool obsahujeCislici = false;

foreach (char znak in vstup)
{
    if (char.IsDigit(znak))
    {
        int cifra = int.Parse(znak.ToString());
        soucet += cifra;
        soucin *= cifra;
        obsahujeCislici = true;
    }
}

    if (obsahujeCislici)
    {
        Console.WriteLine("Součet cifer: " + soucet);
        Console.WriteLine("Součin cifer: " + soucin);
    }
    else

    {
        Console.WriteLine("Nebyla zadána žádná číslice.");

    }




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}